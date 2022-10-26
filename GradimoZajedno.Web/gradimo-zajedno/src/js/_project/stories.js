const stories = {
	path: window.location.pathname,
	serverUrl: 'https://gradimozajedno.codeforacause.rs/timecapsule/getallstories',
	recievedObjectsFromServer: {},
	storiesContainer: document.querySelector('.js-stories-container'),

	init: function() {
		if (!this.storiesContainer) {
			return;
		}
		this.serverLinkChangeFromLang();
	},

	serverLinkChangeFromLang: function() {
		if (this.path.search('/en') === 0) {
			this.serverUrl = this.serverUrl + '?lang=en';
 		}
		this.getAllObjects();
	},

	getAllObjects: function() {
		const _this = this;
		$.ajax({
			type: 'GET',
			contentType: 'application/json',
			url: this.serverUrl,
			dataType: 'json',
			success: function(data) {
				_this.recievedObjectsFromServer = data;
				_this.importObjectToDom();
			}
		});

	},

	importObjectToDom: function() {
		if (!this.recievedObjectsFromServer.length) {
			return;
		}

		const storyList = this.recievedObjectsFromServer;

		storyList.map((story) => {
			const container = document.createElement('div');
			container.setAttribute('class', 'story js-story');

			container.innerHTML = `
            <div class="story__header">
            ${story?.title && `<span class="story__title">${story.title}</span>`}
            ${story?.date && `<time datetime=${story.date}>${story.date}</time>`}
            </div>

            <div class="story__body">
                <div class="story__body-holder">
                    ${story?.text && `<p class="text story__text">${story.text}</p>`}
                </div>
            </div>
            `;
			this.storiesContainer.appendChild(container);
		});
		const paginationContainer = document.createElement('div');
		paginationContainer.setAttribute('class', 'pagination js-stories-pagination');
		const pageAmount = Math.ceil(this.recievedObjectsFromServer?.length / 6);
		const array = Array.from(Array(pageAmount).keys());

		paginationContainer.innerHTML = `
			<div class="wrap">
				<div class="pagination__content">
					<ul class="pagination__list">
						${array.map((element, index) => `<li class="pagination__item">
						<button type="button" class="pagination__link ${index === 0 ? 'pagination__link--active' : ''} js-stories-pagination-button" data-number=${index + 1}>
							${index + 1}
						</button>
						</li>`).join('')}
					</ul>
				</div>
			</div>
		`;

		this.storiesContainer.appendChild(paginationContainer);
		this.addEventListenersToPaginationButton();
	},

	addEventListenersToPaginationButton: function() {
		const buttons = document.querySelectorAll('.js-stories-pagination-button');
		const objects = document.querySelectorAll('.js-story');

		buttons.forEach((button) => {
			button.addEventListener('click', this.onPaginationClick);
		});

		Array.from(objects).map((element, index) => {
			index > 5 && element.classList.add('sr-only');
		});
	},

	onPaginationClick: function(e) {
		const clicked = e.target;
		const clickedPageNumeber = e.target.getAttribute('data-number');
		const objects = document.querySelectorAll('.js-story');
		const buttons = document.querySelectorAll('.js-stories-pagination-button');

		buttons.forEach((button) => {
			button.classList.remove('pagination__link--active');
		});

		clicked.classList.add('pagination__link--active');

		if (clickedPageNumeber === '1') {
			return Array.from(objects).map((element, index) => {
				index > 5 ? element.classList.add('sr-only') : element.classList.remove('sr-only');
			});
		}

		const condition = ((clickedPageNumeber - 1) * 6) - 1;

		Array.from(objects).map((element, index) => {
			if (index > condition && index - 1 < condition + 6) {
			 	element.classList.remove('sr-only');
			} else {
				element.classList.add('sr-only');
			}
		});
	}
};

export default stories;
