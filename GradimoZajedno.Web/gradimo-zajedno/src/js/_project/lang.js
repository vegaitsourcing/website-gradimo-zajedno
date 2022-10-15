const lang = {
	langToggle: document.querySelector('.js-lang-toggle'),
	path: window.location.pathname,

	init: function() {
		window.addEventListener('load', () => {
			const dataChecked = this.langToggle.getAttribute('data-checked');

			if (dataChecked === 'true') {
				this.changeToEn();
			} else {
				this.changeToSr();
			}

		});
		this.langToggleEventListener();
	},

	langToggleEventListener: function() {
		if (!this.langToggle) return;
		this.langToggle.addEventListener('click', (e) => {

			const dataChecked = e.target.getAttribute('data-checked');

			if (dataChecked === 'false') {
				this.changeToEn();
				e.target.setAttribute('data-checked', 'true');
			} else {
				this.changeToSr();
				e.target.setAttribute('data-checked', 'false');
			}

		});
	},

	changeToSr: function() {
		if (this.path.search('/en') === 0) {
			window.location = this.path.slice(3, this.path.length);
		}
	},

	changeToEn: function() {
		if (this.path.search('/en') === -1) {
			window.location = `/en${this.path}`;
		}
	}

};

export default lang;
