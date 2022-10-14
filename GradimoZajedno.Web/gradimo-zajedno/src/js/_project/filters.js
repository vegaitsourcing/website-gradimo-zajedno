import helpers from './helpers';

const filters = {
	filter: document.querySelector('.js-filters'),
	openFilterBtn: document.querySelector('.js-filters-btn'),
	closeFilterBtn: document.querySelector('.js-filters-close-btn'),
	filterInputs: document.querySelectorAll('.js-filter-input'),

	filterActiveClass: 'filters--active',

	init: function() {
		this.filtersOpenEvents();
		this.filtersCloseEvents();
	},

	filtersOpenEvents: function() {
		if (!this.openFilterBtn) {return;}
		this.openFilterBtn.addEventListener('click', () => {
			this.filter.classList.add(this.filterActiveClass);
			helpers.disableScroll();
		});
	},

	filtersCloseEvents: function() {
		if (!this.closeFilterBtn) {return;}
		this.closeFilterBtn.addEventListener('click', () => {
			this.filter.classList.remove(this.filterActiveClass);
			helpers.enableScroll();
		});
	}
};

export default filters;
