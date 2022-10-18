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
		const filterButtons = document.querySelectorAll('.js-obejcts-filter-button');
		filterButtons.forEach((button) => button.classList.remove('filter__label--checked'));
		const button = e.target;
		const buttonAttribute = e.target.getAttribute('data-name');
		const items = document.querySelectorAll('.js-object-item-cont');
		button.classList.add('filter__label--checked');
		items.forEach((item) => {
			if (buttonAttribute === '') {
				return item.classList.remove('sr-only');
			}

			const itemTags = item.getAttribute('data-tags').split(',');

			if (itemTags.find((el) => el === buttonAttribute)) {
				return item.classList.remove('sr-only');
			} else {
				return item.classList.add('sr-only');
			}
		});
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
		const clickedPageNumeber = e.target.getAttribute('data-number');
		const objects = document.querySelectorAll('.js-object-item-cont');

		if (clickedPageNumeber === '1') {
			return Array.from(objects).map((element, index) => {
				index > 5 ? element.classList.add('sr-only') : element.classList.remove('sr-only');
			});
		}

		const condition = ((clickedPageNumeber - 1) * 6) - 1;

		Array.from(objects).map((element, index) => {
			if (index > condition && index < condition + 6) {
			 	element.classList.remove('sr-only');
			} else {
				element.classList.add('sr-only');
			}
		});
	}
};

export default objectsFilter;
