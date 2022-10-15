import QRCode from 'easyqrcodejs';

const donateModal = {
	donatorInformation: document.querySelector('.donate-modal__textarea'),
	donatorValue: document.querySelector('.donate-modal__input'),
	donatorForm: document.querySelector('.donate-modal__form'),

	onInputValuesChange: function() {
		const qrCodeContainer = document.querySelector('.donate-modal__qrcode');
		const donatorValue = document.querySelector('.donate-modal__input');
		const donatorInformation = document.querySelector('.donate-modal__textarea');

		const informationObject = {
			K: 'PR',
			V: '01',
			C: '1',
			R: '265161031000428179',
			N: `Udruženje 'Uvek sa decom'
            Pasterova 14
            11000 beograd`,
			I: `RSD${donatorValue.value || ''},00`,
			P: donatorInformation.value || '',
			SF: '221',
			S: 'Donacija'
		};

		function objToString(obj) {
			let str = '';

			for (const [p, val] of Object.entries(obj)) {
				str += `${p}:${val}|`;
			}

			return str.slice(0, str.length - 1);
		}

		const options = {
			text: objToString(informationObject),
			correctLevel: QRCode.CorrectLevel.L
		};

		qrCodeContainer.innerHTML = '';
		new QRCode(qrCodeContainer, options);
	},

	onDonatorInformationChange: function(e) {
		this.onInputValuesChange(e);
	},

	onFormSubmit: function(e) {e.preventDefault();},

	donatorFormEventListener: function() {
		this.donatorForm.addEventListener('submit', this.onFormSubmit);
	},

	init: function() {
		if (!this.donatorInformation || !this.donatorValue) {
			return;
		}
		this.donatorInformation.addEventListener('change', this.onInputValuesChange);

		this.donatorValue.addEventListener('change', this.onInputValuesChange);

		this.donatorFormEventListener();

	}
};

export default donateModal;
