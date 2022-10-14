import Swiper from 'swiper';
import { Navigation, Pagination } from 'swiper/core';

const slider = {
	selector: '.js-slider',

	init: function() {
		this.swiper();
	},

	swiper: function() {
		// eslint-disable-next-line no-unused-vars
		const swiper = new Swiper('.js-swiper', {
			// Optional parameters
			loop: true,
			spaceBetween: 20,

			// If we need pagination
			pagination: {
				el: '.swiper-pagination',
			},

			// Navigation arrows
			navigation: {
				nextEl: '.swiper-button-next',
				prevEl: '.swiper-button-prev'
			},

			modules: [Navigation, Pagination]
		});
	}
};

export default slider;
