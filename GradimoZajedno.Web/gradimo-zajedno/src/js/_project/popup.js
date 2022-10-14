import helpers from './helpers';

const popup = {
	popups: document.querySelectorAll('.js-popup'),
	btn: document.querySelectorAll('.js-popup-btn'),
	closeBtn: document.querySelectorAll('.js-close-popup'),

	popupActiveClass: 'popup--active',

	init: function() {
		this.popupEvents();
		document.addEventListener('keydown', (e) => {
			this.popups.forEach((pop) => {
				const focusable = pop.querySelectorAll('button, [href], input, select, textarea, [tabindex]:not([tabindex="-1"])');
				const popupParent = pop.closest('.js-popup-parent');
				const popupBtn = popupParent.querySelector('.js-popup-btn');
				const closeButton = pop.querySelector('.js-close-popup');
				const active = document.activeElement;
				if (pop.classList.contains(this.popupActiveClass) && e.key === 'Escape') {
					popupBtn.focus();
					pop.classList.remove(this.popupActiveClass);
					helpers.enableScroll();
				} else if (focusable[focusable.length - 1] === active && e.key === 'Tab' && !e.shiftKey) {
					e.preventDefault();
					closeButton.focus();
				} else if (closeButton === active && e.key === 'Tab' && e.shiftKey) {
					e.preventDefault();
					focusable[focusable.length - 1].focus();
				}
			});
		});
	},

	popupEvents: function() {
		this.btn.forEach((button) => {
			button.addEventListener('click', (e) => {
				const clicked = e.target;
				const parent = clicked.closest('.js-popup-parent');
				const popup = parent.querySelector('.js-popup');
				const closeButton = parent.querySelector('.js-close-popup');
				popup.classList.add(this.popupActiveClass);
				closeButton.focus();
				helpers.disableScroll();
			});
		});
		this.closeBtn.forEach((closeButton) => {
			closeButton.addEventListener('click', (e) => {
				const clicked = e.target;
				const parent = clicked.closest('.js-popup-parent');
				const openButton = parent.querySelector('.js-popup-btn');
				const popup = parent.querySelector('.js-popup');
				popup.classList.remove(this.popupActiveClass);
				openButton.focus();
				helpers.enableScroll();
			});
		});
	}
};

export default popup;
