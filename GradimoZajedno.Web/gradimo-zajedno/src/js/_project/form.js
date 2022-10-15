
const form = {
	form: document.querySelectorAll('.js-form'),
	inputs: document.querySelectorAll('.js-input'),
	submit: document.querySelectorAll('.js-submit'),

	init: function() {
		this.formsEventListener();
	},

	onFormSubmit: function(e) {
		e.preventDefault();
		console.log('onFormSubmit JS funciton');
		const form = e.target;
		const formName = form.getAttribute('data-name');
		const serializedForm = $(form).serializeArray();
		let endpoint = '';
		let formData = {};

		if (!serializedForm.length || !formName) return;

		serializedForm.forEach((element) => {
			if (!element?.name || !element?.value) return;

			formData = { ...formData, [element.name]: element.value };
		});

		switch (formName) {
			case 'buy': endpoint = '/forms/buy';
				break;
			case 'contact': endpoint = '/forms/contact';
				break;
			case 'timecapsule': endpoint = '/forms/timecapsule';
				break;
			default:

		}

		if (!endpoint) return;
		console.log(endpoint);
		console.log(JSON.stringify(formData));

		$.post(endpoint, JSON.stringify(formData)).done(() => {
			alert('second success');
		});
	},

	formsEventListener: function() {
		this.form.forEach((element) => {
			element.addEventListener('submit', this.onFormSubmit);
		});
	},

};

export default form;
