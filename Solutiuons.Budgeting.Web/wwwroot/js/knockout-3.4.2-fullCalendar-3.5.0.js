(function () {
    ko.bindingHandlers.fullCalendar = {
        init: function (element, optionsAccessor) {
            var options = ko.unwrap(optionsAccessor());
            options.events = ko.utils.unwrapObservable(options.events);
            $(element).fullCalendar(options);
        },
        update: function (element, viewModelAccessor) {
            var options = ko.unwrap(viewModelAccessor());
            $(element).fullCalendar('removeEvents');
            $(element).fullCalendar('renderEvents', ko.utils.unwrapObservable(options.events));
        }
    };
})();