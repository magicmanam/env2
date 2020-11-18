$(function () {

});

window.onload = function (e) {
    
};

function makeToggleableContent(contentId, showLinkId, hideLinkId) {
    $('#' + showLinkId).click(function () {
        $(this).hide();
        $('#' + hideLinkId).show();
        $('#' + contentId).show();
    });
    $('#' + hideLinkId).click(function () {
        $(this).hide();
        $('#' + showLinkId).show();
        $('#' + contentId).hide();
    });
}

initToggleableContent();
function initToggleableContent() {
    $('.env2-toggleable-content').each(function () {
        toggleElement($(this));
    });
}

function toggleElement($element, isNotHidden) {
    var $hideTrigger = $('#' + $element.data('hide-id')),// via comma
        $showTrigger = $('#' + $element.data('show-id'));

    $showTrigger.click(function () {
        $showTrigger.hide();
        $hideTrigger.show();
        $element.show();
    });
    $hideTrigger.click(function () {
        $hideTrigger.hide();
        $showTrigger.show();
        $element.hide();
    });

    if (!isNotHidden && !$element.data('isNotHidden')) {
        $element.hide();
    }
}

function toggleElementById(contentId, isNotHidden) {
    toggleElement($('#' + contentId), isNotHidden);
}