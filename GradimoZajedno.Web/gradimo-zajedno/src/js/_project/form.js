const form = {
	form: document.querySelectorAll('.js-form'),
	inputs: document.querySelectorAll('.js-input'),
	submit: document.querySelectorAll('.js-submit'),

	init: function() {
		this.formsEventListener();
	},

	onFormSubmit: function(e) {
		console.log('Form submited');
	},

	formsEventListener: function() {
		this.form.forEach((element) => {
			element.addEventListener('submit', this.onFormSubmit);
		});
	},

};

export default form;
