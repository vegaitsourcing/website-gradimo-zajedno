import objectsFilter from './objects-filter';

const objectsRender = {
	path: window.location.pathname,
	serverUrl: 'https://gradimozajedno.codeforacause.rs/buildings/GetAllSettlementBuildings',
	recievedObjectsFromServer: {},
	paginationInnerElements: [],

	globalDomContainer: document.querySelector('.js-object-global-cont'),
	domTopFilterRow: document.querySelector('.js-objects-top-filter-row'),
	domBottomFilterRow: document.querySelector('.js-objects-bottom-filter-row'),
	domObjectsContainer: document.querySelector('.js-object-item-container'),

	init: function() {
		if (!this.globalDomContainer) return;

		this.serverLinkChangeFromLang();
	},

	serverLinkChangeFromLang: function() {
		if (this.path.search('/en') === 0) {
			this.serverUrl = this.serverUrl + '?lang=en';
 		}
		this.getAllObjects();
	},

	getAllObjects: function() {
		const _this = this;
		$.ajax({
			type: 'GET',
			contentType: 'application/json',
			url: this.serverUrl,
			dataType: 'json',
			success: function(data) {
				_this.recievedObjectsFromServer = data;
				_this.importFiltersToDom();
				_this.importObjectToDom();
			}
		});

	},

	importFiltersToDom: function() {
		if (this.recievedObjectsFromServer['filterTop'] && this.domTopFilterRow) {
			// Create DOM elements for top filter list

			const filterData = this.recievedObjectsFromServer['filterTop'];

			filterData.map((element) => {
				const container = document.createElement('div');
				container.setAttribute('class', 'filter');
				const button = document.createElement('button');
				button.setAttribute('type', 'button');
				button.setAttribute('class', 'filter__label js-obejcts-filter-button');
				button.setAttribute('data-name', element.id);
				button.innerHTML = element.name;

				container.appendChild(button);

				this.domTopFilterRow.appendChild(container);
			});
		}

		if (this.recievedObjectsFromServer['filterBottom'] && this.domBottomFilterRow) {
			// Create DOM elements for bottom filter list

			const filterData = this.recievedObjectsFromServer['filterBottom'];

			filterData.map((element, index) => {
				const container = document.createElement('div');
				container.setAttribute('class', 'filter');
				const button = document.createElement('button');
				button.setAttribute('type', 'button');
				button.setAttribute('class', 'filter__label js-obejcts-filter-button');
				button.setAttribute('data-name', element.id);
				button.innerHTML = element.name;

				if (index === 0) {
					button.classList.add('filter__label--checked');
				}

				container.appendChild(button);

				this.domBottomFilterRow.appendChild(container);
			});
		}
	},

	importObjectToDom: function() {
		if (!this.recievedObjectsFromServer['item'] || !this.domObjectsContainer) {
			return;
		}

		const itemsList = this.recievedObjectsFromServer['item'];

		itemsList.map((item) => {
			const filterTags = item?.filterTags || [];
			const soldAttributeValue = filterTags.find((element) => element === 'sold');

 			const container = document.createElement('div');
			container.setAttribute('class', `item js-object-item-cont ${soldAttributeValue ? 'item--sold' : ''}`);
			container.setAttribute('data-tags', filterTags);

			container.innerHTML = `
			<div class="item__col item__col--sm">
				<div class="item__overlay">
					<span class="item__overlay-span">Prodato</span>
				</div>
				<div class="item__img has-cover" style="background-image: url(${item?.img || ''});"></div>
			</div>

			<div class="item__col">


					<div class="item__header">
						<div class="item__header-col">
							${item?.object && `<span class="item__desc item__desc--lg">${item.object}</span>`}
							${item?.location && `<span class="item__desc">${item.location}</span>`}
						</div>
						<div class="item__header-col item__header-col--flex">
							${item?.tag?.length ? item.tag.map((tag) => `<span class="tag tag--${tag?.class}">${tag?.name}</span>`) : ''}

						</div>
					</div>

					<div class="item__body">
								<div class="item__body-col">
									${item?.text && `<p class="text text--sm item__text">${item.text}</p>`}
								</div>
								<div class="item__body-col item__body-col--margin">
									${item?.nameLabel && `<span class="item__desc">${item.nameLabel}</span>`}
									${item?.nameSurname && `<span class="item__desc item__desc--lg">${item.nameSurname}</span>`}
								</div>
								<div class="item__body-col item__body-col--flex">
									<div class="item__price">
										${soldAttributeValue ? `<span class="item__desc">${item?.ownerLabel}</span>
											<span class="item__desc item__desc--lg">${item?.nameSurname}</span>` : `<span class="item__desc">${item?.priceTag}</span>
											<span class="item__desc item__desc--lg">${item?.price}</span>`}
									</div>

									<a href="${item?.url}" class="item__btn">${item?.btn}</a>
								</div>
							</div>

			</div>
			`;

			this.domObjectsContainer.appendChild(container);

		});
		const paginationContainer = document.createElement('div');
		paginationContainer.setAttribute('class', 'pagination js-items-pagination');
		const pageAmount = Math.floor(this.recievedObjectsFromServer?.item?.length / 6) + 1;
		const array = Array.from(Array(pageAmount).keys());

		paginationContainer.innerHTML = `
			<div class="wrap">
				<div class="pagination__content">
					<ul class="pagination__list">
						${array.map((element, index) => `<li class="pagination__item">
						<button type="button" class="pagination__link js-objects-pagination-button" data-number=${index + 1}>
							${index + 1}
						</button>
						</li>`)}

					</ul>
				</div>
			</div>
		`;

		this.domObjectsContainer.appendChild(paginationContainer);

		objectsFilter.init();
	}
};

export default objectsRender;
