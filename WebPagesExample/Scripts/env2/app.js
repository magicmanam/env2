$(function () {
    pro.tree.document();
});

window.onscroll = function scrollFunction() {
    pro.id('2-top').style.display = (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) ? 'block' : 'none';
};

function topFunction() {
    document.body.scrollTop = 0; // Safari
    document.documentElement.scrollTop = 0; // Chrome, Firefox, IE and Opera
}

env2 = {};

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