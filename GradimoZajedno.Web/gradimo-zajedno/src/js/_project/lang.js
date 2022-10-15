const lang = {
	langToggle: document.querySelector('.js-lang-toggle'),
	path: window.location.pathname,

	init: function() {
		window.addEventListener('load', () => {

			if (this.path.search('/en') === 0) {
				this.langToggle.setAttribute('data-checked', 'true');
				this.langToggle.setAttribute('checked', true);
			} else {
				this.langToggle.setAttribute('data-checked', 'false');
				this.langToggle.removeAttribute('checked');
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
			} else {
				this.changeToSr();
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
