const objectsFilter = {
	filterContainer: document.querySelector('.js-object-global-cont'),

	init: function() {
		if (!this.filterContainer) return;

		this.addListenersToFilterButtons();
		this.addEventListenersToPaginationButton();
	},

	addListenersToFilterButtons: function() {
		const filterButtons = document.querySelectorAll('.js-obejcts-filter-button');
		filterButtons.forEach((button) => button.addEventListener('click', this.onButtonClick));
	},

	onButtonClick: function(e) {
		const filterButtons = [...document.querySelectorAll('.js-objects-bottom-filter-row .js-obejcts-filter-button')];
		const quarterButtons = [...document.querySelectorAll('.js-objects-top-filter-row .js-obejcts-filter-button')];
		const button = e.target;

		if (filterButtons.includes(button)) {
			filterButtons.forEach((button) => button.classList.remove('filter__label--checked'));
		} else {
			quarterButtons.forEach((button) => button.classList.remove('filter__label--checked'));
			filterButtons.forEach((button) => button.classList.remove('filter__label--checked'));
		}
		button.classList.add('filter__label--checked');

		let activeQuarter = null;
		for (const b of quarterButtons) {
			if (b.classList.contains('filter__label--checked')) {
				activeQuarter = b.getAttribute('data-name');
			}
		}

		const activeFilter = e.target.getAttribute('data-name');
		const allItems = document.querySelectorAll('.js-object-item-cont');

		allItems.forEach((item) => {
			if (activeFilter === '') {
				item.classList.remove('sr-only', 'active-item');
			}

			const itemTags = item.getAttribute('data-tags').split(',');

			if (itemTags.find((tag) => tag === activeFilter || activeFilter === '')) {
				if (activeQuarter === null || activeQuarter !== null && itemTags.find((tag) => tag === activeQuarter)) {
					item.classList.remove('sr-only');
				} else {
					item.classList.add('sr-only');
				}
			} else {
				item.classList.add('sr-only');
			}
		});

		updatePagination(allItems);

		function updatePagination(elements) {
			const filteredArray = [];
			const paginationButtons = document.querySelectorAll('.js-objects-pagination-button');
			elements.forEach((element) => {
				element.classList.remove('active-item');
				if (!element.classList.contains('sr-only')) {
					filteredArray.push(element);

					const condition = 6;

					paginationButtons.forEach((button, index) => {
						button.classList.remove('pagination__link--active');
						if (filteredArray.length < 6) {
							if (index > 0) {
								button.classList.add('sr-only');
							} else {
								button.classList.add('pagination__link--active');
							}
						} else {
							if (index === 0) {
								button.classList.add('pagination__link--active');
							}
							button.classList.remove('sr-only');
						}
					});

					filteredArray.map((element, index) => {
						element.classList.add('active-item');
						if (index + 1 > condition) {
							element.classList.add('sr-only');
						} else {
							element.classList.remove('sr-only');
						}
					});
				}
			});
		}
	},

	addEventListenersToPaginationButton: function() {
		const buttons = document.querySelectorAll('.js-objects-pagination-button');
		const objects = document.querySelectorAll('.js-object-item-cont');

		buttons.forEach((button) => {
			button.addEventListener('click', this.onPaginationClick);
		});

		Array.from(objects).map((element, index) => {
			index > 5 && element.classList.add('sr-only');
		});
	},

	onPaginationClick: function(e) {
		const clicked = e.target;
		const clickedPageNumeber = e.target.getAttribute('data-number');
		const objects = document.querySelectorAll('.active-item');
		const buttons = document.querySelectorAll('.js-objects-pagination-button');

		buttons.forEach((button) => {
			button.classList.remove('pagination__link--active');
		});

		clicked.classList.add('pagination__link--active');

		if (clickedPageNumeber === '1') {
			return Array.from(objects).map((element, index) => {
				index > 5 ? element.classList.add('sr-only') : element.classList.remove('sr-only');
			});
		}

		const condition = ((clickedPageNumeber - 1) * 6) - 1;

		Array.from(objects).map((element, index) => {
			if (index > condition && index - 1 < condition + 6) {
				element.classList.remove('sr-only');
			} else {
				element.classList.add('sr-only');
			}
		});
	}
};

export default objectsFilter;
