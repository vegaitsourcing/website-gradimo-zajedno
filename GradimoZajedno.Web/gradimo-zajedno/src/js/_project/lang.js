const lang = {
	langToggle: document.querySelector('.js-lang-toggle'),

	init: function() {
		window.addEventListener('load', () => {
			const dataChecked = this.langToggle.getAttribute('data-checked');
			const origin = window.location.origin;
			const path = window.location.pathname;

			if (dataChecked === 'true') {
				this.changeToEn();
			} else {
				this.changeToSr();
			}

		});
		this.langToggleEventListener();
	},

	langToggleEventListener: function() {
		console.log(this.langToggle);
		if (!this.langToggle) return;
		this.langToggle.addEventListener('click', (e) => {

			const dataChecked = e.target.getAttribute('data-checked');
			console.log(dataChecked);

			if (dataChecked === 'false') {
				this.changeToEn();
				e.target.setAttribute('data-checked', 'true');
			} else {
				this.changeToSr();
				e.target.setAttribute('data-checked', 'false');
			}

			// console.log(!dataChecked);
		});
	},

	changeToSr: function() {
		console.log('change to sr');
		// const dataChecked = this.langToggle.getAttribute('data-checked');
		// this.langToggle.setAttribute('data-checked', !dataChecked);
	},

	changeToEn: function() {
		console.log('change to en');
		// const dataChecked = this.langToggle.getAttribute('data-checked');
		// this.langToggle.setAttribute('data-checked', !dataChecked);
	}

};

export default lang;
