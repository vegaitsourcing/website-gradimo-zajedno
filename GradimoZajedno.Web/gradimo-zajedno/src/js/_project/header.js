import helpers from './helpers';

const header = {
	nav: document.querySelector('.js-nav'),
	menuBtn: document.querySelector('.js-menu'),

	navActiveClass: 'nav--active',

	init: function() {
		this.toggleMenuEvents();
	},

	toggleMenuEvents: function() {
		this.menuBtn.addEventListener('click', () => {
			this.nav.classList.toggle(this.navActiveClass);
			if (this.nav.classList.contains(this.navActiveClass)) {
				helpers.disableScroll();
			} else {
				helpers.enableScroll();
			}
		});
	}
};

export default header;
