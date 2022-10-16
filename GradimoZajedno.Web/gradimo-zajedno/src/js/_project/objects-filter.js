const objectsFilter = {
	filterContainer: document.querySelector('.js-object-global-cont'),

	init: function() {
		if (!this.filterContainer) return;

		this.addListenersToFilterButtons();
	},

	addListenersToFilterButtons: function() {
		const filterButtons = document.querySelectorAll('.js-obejcts-filter-button');
		filterButtons.forEach((button) => button.addEventListener('click', this.onButtonClick));
	},

	onButtonClick: function(e) {
		const buttonAttribute = e.target.getAttribute('data-name');
		const items = document.querySelectorAll('.js-object-item-cont');
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

	}

};

export default objectsFilter;
