const cookieModal = {
	cookieModalEl: document.querySelector('.js-cookie'),
	closeCookieBtn: document.querySelector('.js-close-cookie'),
	allowCookiesBtn: document.querySelector('.js-allow-cookies'),
	declineCookiesBtn: document.querySelector('.js-decline-cookies'),

	cookieModalHiddenClass: 'cookie--hidden',
	active: true,

	init: function() {
		const current = localStorage.getItem('active');
		if (current === 'true' || current === null) {
			this.cookieModalEl.classList.remove(this.cookieModalHiddenClass);
		} else {
			this.cookieModalEl.classList.add(this.cookieModalHiddenClass);
		}
		this.closeCookieModal();
		this.allowCookiesEventListener();
		this.declineCookiesEventListener();
	},

	closeCookieModal: function() {
		this.closeCookieBtn.addEventListener('click', () => {
			this.cookieModalEl.classList.add(this.cookieModalHiddenClass);
		});
	},

	allowCookiesEventListener: function() {
		if (!this.allowCookiesBtn) return;
		this.allowCookiesBtn.addEventListener('click', () => {
			this.cookieModalEl.setAttribute('data-active', false);
			localStorage.setItem('active', false);
			this.active = false;
			this.cookieModalEl.classList.add(this.cookieModalHiddenClass);
		});
	},

	declineCookiesEventListener: function() {
		if (!this.declineCookiesBtn) return;
		this.declineCookiesBtn.addEventListener('click', () => {
			this.cookieModalEl.classList.add(this.cookieModalHiddenClass);
			this.cookieModalEl.setAttribute('data-active', true);
			localStorage.setItem('active', true);
		});
	}
};

export default cookieModal;
