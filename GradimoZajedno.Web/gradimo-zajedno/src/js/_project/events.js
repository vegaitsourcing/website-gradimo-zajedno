import Swiper from 'swiper';
import { Navigation, Pagination } from 'swiper/core';

const events = {
	init: function() {
		this.swiper();
	},

	swiper: function() {
		// eslint-disable-next-line no-unused-vars
		const swiper = new Swiper('.js-swiper-events', {
			// Optional parameters
			loop: false,
			spaceBetween: 20,

			// If we need pagination
			pagination: {
				el: '.swiper-pagination',
			},

			// Navigation arrows
			navigation: {
				nextEl: '.events-button-next',
				prevEl: '.events-button-prev'
			},

			modules: [Navigation, Pagination]
		});
	}
};

export default events;
