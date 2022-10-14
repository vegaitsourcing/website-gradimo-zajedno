import QRCode from 'easyqrcodejs';

const donateModal = {
	donatorInformation: document.querySelector('.donate-modal__textarea'),
	donatorValue: document.querySelector('.donate-modal__input'),

	onInputValuesChange: function() {
		const donatorValue = document.querySelector('.donate-modal__input');
		const donatorInformation = document.querySelector('.donate-modal__textarea');

		console.log(donatorInformation.value);
		console.log(donatorValue.value);

		const informationObject = {
			K: 'PR',
			V: '01',
			C: '1',
			R: '265161031000428179',
			N: `Udruženje 'Uvek sa decom'
            Pasterova 14
            11000 beograd`,
			I: `RSD ${donatorValue.value || ''},00`,
			P: donatorInformation.value || '',
			SF: '',
			S: 'Donacija'
		};

		// Transform this object to string, separated with '/', and put it to text object
		// Then set that object in new QR code

		// Show that QR code in form

		console.log(informationObject);

		// const options = {
		// 	text: 'https://github.com/ushelp/EasyQRCodeJS'
		// };

		// new QRCode(document.querySelector('.donate-modal__qrcode'), options);
	},

	onDonatorInformationChange: function(e) {
		console.log('s');
		this.onInputValuesChange(e);
		// this.onInputValuesChange({ name: 'donator', value: e.target.value });
	},

	onDonatorValueChange: function(e) {
		console.log(e.target.value);
	},

	init: function() {
		if (!this.donatorInformation || !this.donatorValue) {
			return;
		}
		this.donatorInformation.addEventListener('change', this.onInputValuesChange);

		this.donatorValue.addEventListener('change', this.onInputValuesChange);

	}
};

export default donateModal;
