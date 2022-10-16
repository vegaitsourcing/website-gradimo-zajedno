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
			container.setAttribute('class', 'story');

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
	}
};

export default stories;
