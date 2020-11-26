$(function () {
    pro.tree.document();

    $('input[type="Submit"]').button();
    $('input[type="button"]').button();
    $(document).tooltip();

    new ClipboardJS('a.copy-link');
});

window.onscroll = function scrollFunction() {
    pro.id('2-top').style.display = (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) ? 'block' : 'none';
};

window.onbeforeunload = function (e) {
    if (!window.isUnloading) {
        let tip = tips[Math.floor(Math.random() * tips.length)];
        let tipHtml = '<div style="display: table; width: 100%"><div style="height: 600px; display: table-cell; vertical-align: middle;"><h3></h3><div style="margin: 0 auto; width: 50%"><div style="font-weight: bold">'
            + tip + '</div><!--<div><a>Next Tip</a>, Close</div>--></div></div></div>';
        
        sessionStorage.setItem('last-tip', JSON.stringify({ tip: tip, time: new Date().getTime() }));
        //$('.env2-content-wrapper.main-content').html(tipHtml);
        noty({ text: tip, layout: 'bottomCenter', type: 'information', timeout: 5500 });
        
        window.isUnloading = true;
    }
};

window.onload = function (e) {
    var lastTip = sessionStorage.getItem('last-tip');

    if (lastTip) {
        lastTip = JSON.parse(lastTip);
        lastTip.time = 5555 - new Date().getTime() + lastTip.time;

        if (lastTip.time > 0) {
            noty({ text: lastTip.tip, layout: 'bottomCenter', type: 'information', timeout: lastTip.time });
        }
    }
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