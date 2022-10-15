const lang = {
	langToggle: document.querySelector('.js-lang-toggle'),

	init: function() {
		window.addEventListener('load', () => {
			const dataChecked = this.langToggle.getAttribute('data-checked');
			const origin = window.location.origin;
			const path = window.location.pathname;

			if (dataChecked === 'true') {
				console.log('en');
			} else {
				console.log('sr');
			}

		});
		this.langToggleEventListener();
	},

	langToggleEventListener: function() {
		if (!this.langToggle) return;
		this.langToggle.addEventListener('click', () => {
			const dataChecked = this.langToggle.getAttribute('data-checked');
			if (dataChecked === 'false') {
				this.langToggle.setAttribute('data-checked', true);
			} else {
				this.langToggle.setAttribute('data-checked', false);
			}
		});
	}
};

export default lang;
