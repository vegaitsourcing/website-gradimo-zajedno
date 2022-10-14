namespace GradimoZajedno.Models.Converters;

using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Extensions;

public class CustomMediaPickerValueConverter : MediaPickerValueConverter
{
    private const string ImageTypeAlias = Constants.Conventions.MediaTypes.Image;
    private readonly IPublishedModelFactory _publishedModelFactory;

    public CustomMediaPickerValueConverter(IPublishedSnapshotAccessor publishedSnapshotAccessor, IPublishedModelFactory publishedModelFactory)
        : base(publishedSnapshotAccessor, publishedModelFactory)
    {
        _publishedModelFactory = publishedModelFactory;
    }

    public override Type GetPropertyValueType(IPublishedPropertyType propertyType)
    {
        var baseType = base.GetPropertyValueType(propertyType);
        if (!IsOnlyImagesDataType(propertyType.DataType))
        {
            return baseType;
        }

        return (baseType == typeof(IEnumerable<IPublishedContent>))
            ? typeof(IEnumerable<>).MakeGenericType(ModelType.For(ImageTypeAlias))
            : ModelType.For(ImageTypeAlias);
    }

    public override object? ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel cacheLevel, object source, bool preview)
    {
        var baseSource = base.ConvertIntermediateToObject(owner, propertyType, cacheLevel, source, preview);
        if (!IsOnlyImagesDataType(propertyType.DataType))
        {
            return baseSource;
        }

        var imageType = _publishedModelFactory.MapModelType(ModelType.For(ImageTypeAlias));

        if (!(baseSource is IEnumerable<IPublishedContent> mediaItems))
        {
            return baseSource?.GetType().Inherits(imageType) == true ? baseSource : null;
        }

        var images = _publishedModelFactory.CreateModelList(ImageTypeAlias);

        foreach (var mediaItem in mediaItems.Where(mi => mi.GetType().Inherits(imageType)))
        {
            images.Add(mediaItem);
        }

        return images;
    }

    private static bool IsOnlyImagesDataType(PublishedDataType dataType)
    {
        var config = ConfigurationEditor.ConfigurationAs<MediaPickerConfiguration>(dataType.Configuration);
        return config.OnlyImages;
    }
}
