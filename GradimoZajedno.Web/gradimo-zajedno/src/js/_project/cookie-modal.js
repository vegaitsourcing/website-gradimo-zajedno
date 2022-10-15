const cookieModal = {
	cookieModalEl: document.querySelector('.js-cookie'),
	cookieBtn: document.querySelector('.js-cookie-opener'),
	closeCookieBtn: document.querySelector('.js-close-cookie'),
	confirmText: 'Confirm Settings',

	cookieModalHiddenClass: 'cookie--hidden',

	init: function() {
		this.closeCookieModal();
	},

	cookieModal: function() {
		if (!this.cookieBtn) return;
		this.cookieBtn.addEventListener('click', (e) => {
			e.preventDefault();
			CookieControl.open();
			this.cookieAppendInfoButton();
		});
		document.addEventListener('click', (e) => {
			if (e.currentTarget.id === '#confirm-btn') {
				document.getElementById('ccc').innerHTML = '';
			}
		});
	},

	closeCookieModal: function() {
		this.closeCookieBtn.addEventListener('click', () => {
			this.cookieModalEl.classList.add(this.cookieModalHiddenClass);
		});
	},

	cookieAppendInfoButton: function() {
		const $cookiesContainer = $('#ccc');
		const cookieInfoBtn = `<button class="btn-info" id="confirm-btn">${this.confirmText}</button>`;
		setTimeout(() => {
			const confirmBtnHolder = $cookiesContainer.find('#ccc-info');
			if (!$('#confirm-btn').length) {
				confirmBtnHolder.append(cookieInfoBtn);
			}
		}, 200);
	}
};

export default cookieModal;
