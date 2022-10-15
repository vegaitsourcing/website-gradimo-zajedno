import Swiper from 'swiper';
import { Navigation, Pagination } from 'swiper/core';

const cards = {

	cards: Array.from(document.querySelectorAll('.js-card')),
	pagination: document.querySelector('.js-cards-pagination'),
	next: document.querySelector('.cards__btn--next'),
	prev: document.querySelector('.cards__btn--prev'),
	current: 0,

	init: function() {
		if (!this.cards || !this.pagination) {
			return;
		}
		const isMobile = window.matchMedia('only screen and (max-width: 992px)').matches;
		if (isMobile) {
			this.swiper();
		} else {
			this.cardAnimationSettings();
			this.cardEventListener();
		}

	},

	cardAnimationSettings: function() {
		const temp = this.cards[2];
		this.cards[2] = this.cards[3];
		this.cards[3] = temp;
	},

	cardEventListener: function() {
		let isPaused = false;
		let time = 0;
		const t = window.setInterval(() => {
			if (!isPaused) {
				time++;
				cardsHoverRepeat();
			}
		}, 3000);

		const cardsHoverRepeat = () => {
			if (!this.cards) {return;}

			this.cards.forEach((card) => {
				card.classList.remove('card--active');
			});
			this.cards[this.current].classList.add('card--active');
			this.current++;
			if (this.current > this.cards.length - 1) {
				this.current = 0;
			}
		};

		this.cards.forEach((card) => {
			card.addEventListener('mouseenter', (e) => {
				const clicked = e.target;
				isPaused = true;
				this.current = card.getAttribute('data-id');

				const parent = clicked.closest('.js-card');
				this.cards.forEach((card) => {
					card.classList.remove('card--active');
				});
				parent.classList.add('card--active');
			});
			card.addEventListener('mouseleave', (e) => {
				isPaused = false;
			});
		});
	},

	swiper: function() {
		// eslint-disable-next-line no-unused-vars
		const swiper = new Swiper('.js-swiper-cards', {
			// Optional parameters
			loop: false,

			breakpoints: {
				320: {
					slidesPerView: 1,
					spaceBetween: 20
				},
				1200: {
					slidesPerView: 4
				}
			},

			// If we need pagination
			pagination: {
				el: '.swiper-pagination',
				clickable: true
			},

			// Navigation arrows
			navigation: {
				nextEl: '.cards-button-next',
				prevEl: '.cards-button-prev'
			},

			modules: [Navigation, Pagination]
		});
	}
};

export default cards;
