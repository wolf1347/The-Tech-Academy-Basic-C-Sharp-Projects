var ClickCounterViewModel = function () {
    this.numberOfClicks = ko.observable(0);

    this.registerClick = function () {
        this.numberOfClicks(this.numberOfClicks() + 1); // adds one to the counter each time you click
    };

    this.resetClicks = function () {
        this.numberOfClicks(0); // resets the clicks to 0
    };

    this.viewCat = ko.computed(function () {
        return this.numberOfClicks() < 8; // if the clicks are less than 8 you can call on the viewCat function.
    }, this);

    this.hasClickedTooManyTimes = ko.computed(function () {
        return this.numberOfClicks() >= 8; // if clicks are greater than or equal to 8 you can call too many clicks
    }, this);



    
};

ko.applyBindings(new ClickCounterViewModel());
