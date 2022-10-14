const forms = {
	forms: document.querySelectorAll('.js-form'),
	inputs: document.querySelectorAll('.js-input'),
	error: document.querySelectorAll('.js-error-msg'),
	submit: document.querySelectorAll('.js-submit'),

	init: function() {
		this.formsEventListener();
	},

	formsEventListener: function() {
		this.forms.forEach((form) => {
			form.addEventListener('click', (e) => {
				e.preventDefault();

				this.checkValidity();
			});
		});
	},

	checkValidity: function() {
		this.inputs.forEach((input) => {

		});
	}
};

export default forms;
