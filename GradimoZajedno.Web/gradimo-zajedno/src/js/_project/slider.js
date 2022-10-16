import Swiper from 'swiper';
import { Navigation, Pagination } from 'swiper/core';

const slider = {
	options: {},

	init: function() {
		this.swiper();
	},

	swiper: function() {
		if (Array.from(document.querySelectorAll('.js-swiper .swiper-slide')).length === 1) {
			this.options = {
				loop: false,
				spaceBetween: 20,
				slidesPerView: 1,

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
			};
		} else {
			this.options = {
				loop: true,
				spaceBetween: 20,
				slidesPerView: 1,
				loopedSlides: 2,

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
			};
		}
		// eslint-disable-next-line no-unused-vars
		const swiper = new Swiper('.js-swiper', this.options);
	}
};

export default slider;
