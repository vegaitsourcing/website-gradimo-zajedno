const objects = {
	serverUrl: 'https://gradimozajedno.codeforacause.rs/buildings/GetAllSettlementBuildings',
	recievedObjectsFromServer: {},

	globalDomContainer: document.querySelector('.js-object-global-cont'),
	domTopFilterRow: document.querySelector('.js-objects-top-filter-row'),
	domBottomFilterRow: document.querySelector('.js-objects-bottom-filter-row'),
	domObjectsContainer: document.querySelector('.js-object-item-container'),

	init: function() {
		if (!this.globalDomContainer) return;
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

			filterData.map((element) => {
				const container = document.createElement('div');
				container.setAttribute('class', 'filter');
				const button = document.createElement('button');
				button.setAttribute('type', 'button');
				button.setAttribute('class', 'filter__label js-obejcts-filter-button');
				button.setAttribute('data-name', element.id);
				button.innerHTML = element.name;

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
			container.setAttribute('class', `item ${soldAttributeValue ? 'item--sold' : ''}`);

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
					</div>

			</div>
			`;

			this.domObjectsContainer.appendChild(container);
		});
	}
};

export default objects;
