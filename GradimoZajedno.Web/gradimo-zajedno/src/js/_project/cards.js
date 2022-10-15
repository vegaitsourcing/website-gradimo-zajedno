import Swiper from 'swiper';
import { Navigation, Pagination } from 'swiper/core';

const cards = {

	cards: Array.from(document.querySelectorAll('.js-card')),
	pagination: document.querySelector('.js-cards-pagination'),
	next: document.querySelector('.cards__btn--next'),
	prev: document.querySelector('.cards__btn--prev'),
	current: 0,
	dots: [],
	active: 0,

	init: function() {
		if (!this.cards || !this.pagination) {
			return;
		}
		const isMobile = window.matchMedia('only screen and (max-width: 992px)').matches;
		if (isMobile) {
			this.swiper();
		} else {
			this.cardAnimationSettings();
			this.paginationEventListener();
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
				console.log('timer');
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
				const cardId = +parent.getAttribute('data-id');

				this.dots.forEach((dot) => {
					const dotId = +dot.getAttribute('data-id');

					if (dotId === cardId) {
						this.active = dotId;
						this.current = dotId;
					}
				});
				this.updatePagination();
			});
			card.addEventListener('mouseleave', (e) => {
				isPaused = false;
			});
		});
	},

	generatePagination: function() {
		const cardsLength = this.cards.length;
		for (let i = 0; i < cardsLength; i++) {
			const dot = document.createElement('span');
			dot.classList.add('dot');
			dot.setAttribute('data-id', i);
			this.dots.push(dot);
			this.dots[0].classList.add('dot--active');
			this.pagination.appendChild(dot);
		}
	},

	paginationEventListener: function() {
		this.dots.forEach((dot) => {
			dot.addEventListener('click', (e) => {
				this.dots.forEach((dot) => dot.classList.remove('dot--active'));
				const clicked = e.target;
				clicked.classList.add('dot--active');
				const dotId = +clicked.getAttribute('data-id');
				if (dotId === this.cards.length - 1) {
					this.next.classList.add('disabled');
					this.prev.classList.remove('disabled');
				} else if (dotId === 0) {
					this.prev.classList.add('disabled');
					this.next.classList.remove('disabled');
				} else {
					this.prev.classList.remove('disabled');
					this.next.classList.remove('disabled');
				}
				this.active = dotId;
				this.current = dotId;
				this.cards.forEach((card) => {
					card.classList.remove('block--active');
					const cardId = +card.getAttribute('data-id');
					if (dotId === cardId) {
						card.classList.add('block--active');
					}
				});
			});
		});
	},

	updatePagination: function() {
		this.cards.forEach((card) => {
			if (card.classList.contains('card--active')) {
				const cardId = +card.getAttribute('data-id');
				this.dots.forEach((dot) => {
					dot.classList.remove('dot--active');
					const dotId = +dot.getAttribute('data-id');
					if (cardId === dotId) {
						dot.classList.add('dot--active');
						this.active = dotId;
						this.current = dotId;
					}
				});
			}
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
