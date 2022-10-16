
const form = {
	form: document.querySelectorAll('.js-form'),
	inputs: document.querySelectorAll('.js-input'),
	submit: document.querySelectorAll('.js-submit'),

	init: function() {
		this.formsEventListener();
	},

	onFormSubmit: function(e) {
		e.preventDefault();
		const form = e.target;
		const popup = document.querySelector('.js-popup');
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

		const onSuccess = function() {
			popup.classList.add('popup--success');
		};

		$.ajax({
			type: 'POST',
			contentType: 'application/json',
			url: endpoint,
			data: JSON.stringify(formData),
			dataType: 'json',
			success: onSuccess(),

		});
		function showSuccessMessage(element) {
			const messageEl = document.createElement('p');
			messageEl.classList.add('form__success-msg');
			messageEl.textContent = 'Poruka uspješno poslana!';
			element.appendChild(messageEl);
			const inputs = form.querySelectorAll('.input');
			inputs.forEach((input) => {
				input.value = '';
			});
		}

		showSuccessMessage(form);
	},

	formsEventListener: function() {
		this.form.forEach((element) => {
			element.addEventListener('submit', this.onFormSubmit);
		});
	},

};

export default form;
