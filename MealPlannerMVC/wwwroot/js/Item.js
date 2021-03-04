var Item = Item || {};

Item.Index = function (config) {
	BasePage.List.apply(this, arguments);
}

Item.Index.prototype = Object.create(BasePage.List.prototype);

Item.Index.prototype.init = function () {
    this.bindDeleteEvents();
}

Item.Index.prototype.bindDeleteEvents = function () {
	this.dataTable.on('click', 'button[data-action="delete"]', this.delete);
}

Item.Index.prototype.delete = function (e) {
	deleteEntity(e, 'Item');
}
