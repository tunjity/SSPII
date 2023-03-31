
function loader() {
    
    $('div.test').block({
        message: '<h1>Processing</h1>',
        css: { border: '3px solid #a00' }
    });
}

function jsfn_HideLoading() {
    $.unblockUI();
}
function showImage() {
    document.getElementById('<%=div_loading.ClientID%>').style.display = "block";
}

function startCorporateSyncing() {
    

    swal({
        title: "Do not Close this window</strong>",
        text: 'Closing this window may cause loss in the data',
        buttons: {
            cancel: true,
            confirm: "Submit"

        }
        //    'Closing this window may cause loss in the data',
        //showCloseButton: true,
        //showCancelButton: true,
        //focusConfirm: false,
        //confirmButtonText:
        //    'Start',
        //confirmButtonAriaLabel: 'Start!',
        //cancelButtonText:
        //    'Cancel',
        //cancelButtonAriaLabel: 'Thumbs down',
    }).then((result) => {
        console.log("i got here");
        if (result.value) {
            //truncateData_start_syncing();
            truncateCorporateData_start_syncing();
            Swal.fire({

                showCancelButton: false,
                showConfirmButton: false,
                title: 'Syncing',
                html: '<img width=40 src="https://gifimage.net/wp-content/uploads/2018/04/loader-gif-transparent-background-11.gif"/><div class="progress">' +

                    '<div class="progress-meter" style="width:0%"></div>' +
                    '</div >' +
                    '<span class="progress-val">0%</span> complete ',
                allowOutsideClick: false


            });
        }
    })
};


function startIndividualsSync() {
    Swal.fire({
        title: '<strong>Do not Close this window</strong>',
        type: 'info',
        html:
            'Closing this window may cause loss in the data',
        showCloseButton: true,
        showCancelButton: true,
        focusConfirm: false,
        confirmButtonText:
            'Start',
        confirmButtonAriaLabel: 'Start!',
        cancelButtonText:
            'Cancel',
        cancelButtonAriaLabel: 'Thumbs down',
    }).then((result) => {
        if (result.value) {
            //truncateData_start_syncing();
            truncateIndividualsData_start_syncing();
            Swal.fire({

                showCancelButton: false,
                showConfirmButton: false,
                title: 'Syncing',
                html: '<img width=40 src="https://gifimage.net/wp-content/uploads/2018/04/loader-gif-transparent-background-11.gif"/><div class="progress">' +

                    '<div class="progress-meter" style="width:0%"></div>' +
                    '</div >' +
                    '<span class="progress-val">0%</span> complete ',
                allowOutsideClick: false


            });
        }
    })
};



function startProfileSync() {
    Swal.fire({
        title: '<strong>Do not Close this window</strong>',
        type: 'info',
        html:
            'Closing this window may cause loss in the data',
        showCloseButton: true,
        showCancelButton: true,
        focusConfirm: false,
        confirmButtonText:
            'Start',
        confirmButtonAriaLabel: 'Start!',
        cancelButtonText:
            'Cancel',
        cancelButtonAriaLabel: 'Thumbs down',
    }).then((result) => {
        if (result.value) {
            //truncateData_start_syncing();
            truncateProfileData_start_syncing();
            Swal.fire({

                showCancelButton: false,
                showConfirmButton: false,
                title: 'Syncing',
                html: '<img width=40 src="https://gifimage.net/wp-content/uploads/2018/04/loader-gif-transparent-background-11.gif"/><div class="progress">' +

                    '<div class="progress-meter" style="width:0%"></div>' +
                    '</div >' +
                    '<span class="progress-val">0%</span> complete ',
                allowOutsideClick: false


            });
        }
    })
};

function startProfileSyncB() {
    Swal.fire({
        title: '<strong>Do not Close this window</strong>',
        type: 'info',
        html:
            'Closing this window may cause loss in the data',
        showCloseButton: true,
        showCancelButton: true,
        focusConfirm: false,
        confirmButtonText:
            'Start',
        confirmButtonAriaLabel: 'Start!',
        cancelButtonText:
            'Cancel',
        cancelButtonAriaLabel: 'Thumbs down',
    }).then((result) => {
        if (result.value) {
            //truncateData_start_syncing();
            truncateProfileData_start_syncingB();
            Swal.fire({

                showCancelButton: false,
                showConfirmButton: false,
                title: 'Syncing',
                html: '<img width=40 src="https://gifimage.net/wp-content/uploads/2018/04/loader-gif-transparent-background-11.gif"/><div class="progress">' +

                    '<div class="progress-meter" style="width:0%"></div>' +
                    '</div >' +
                    '<span class="progress-val">0%</span> complete ',
                allowOutsideClick: false


            });
        }
    })
};

function startProfileSyncC() {
    Swal.fire({
        title: '<strong>Do not Close this window</strong>',
        type: 'info',
        html:
            'Closing this window may cause loss in the data',
        showCloseButton: true,
        showCancelButton: true,
        focusConfirm: false,
        confirmButtonText:
            'Start',
        confirmButtonAriaLabel: 'Start!',
        cancelButtonText:
            'Cancel',
        cancelButtonAriaLabel: 'Thumbs down',
    }).then((result) => {
        if (result.value) {
            //truncateData_start_syncing();
            truncateProfileData_start_syncingC();
            Swal.fire({

                showCancelButton: false,
                showConfirmButton: false,
                title: 'Syncing',
                html: '<img width=40 src="https://gifimage.net/wp-content/uploads/2018/04/loader-gif-transparent-background-11.gif"/><div class="progress">' +

                    '<div class="progress-meter" style="width:0%"></div>' +
                    '</div >' +
                    '<span class="progress-val">0%</span> complete ',
                allowOutsideClick: false


            });
        }
    })
};


//start reules syncing data
function startRuleSync() {
    Swal.fire({
        title: '<strong>Do not Close this window</strong>',
        type: 'info',
        html:
            'Closing this window may cause loss in the data',
        showCloseButton: true,
        showCancelButton: true,
        focusConfirm: false,
        confirmButtonText:
            'Start',
        confirmButtonAriaLabel: 'Start!',
        cancelButtonText:
            'Cancel',
        cancelButtonAriaLabel: 'Thumbs down',
    }).then((result) => {
        if (result.value) {
            //truncateData_start_syncing();
            truncateRulesData_start_syncing();
            Swal.fire({

                showCancelButton: false,
                showConfirmButton: false,
                title: 'Syncing',
                html: '<img width=40 src="https://gifimage.net/wp-content/uploads/2018/04/loader-gif-transparent-background-11.gif"/><div class="progress">' +

                    '<div class="progress-meter" style="width:0%"></div>' +
                    '</div >' +
                    '<span class="progress-val">0%</span> complete ',
                allowOutsideClick: false


            });
        }
    })

};

//start reules syncing data
function startRuleSyncB() {
    Swal.fire({
        title: '<strong>Do not Close this window</strong>',
        type: 'info',
        html:
            'Closing this window may cause loss in the data',
        showCloseButton: true,
        showCancelButton: true,
        focusConfirm: false,
        confirmButtonText:
            'Start',
        confirmButtonAriaLabel: 'Start!',
        cancelButtonText:
            'Cancel',
        cancelButtonAriaLabel: 'Thumbs down',
    }).then((result) => {
        if (result.value) {
            //truncateData_start_syncing();
            truncateRulesData_start_syncingB();
            Swal.fire({

                showCancelButton: false,
                showConfirmButton: false,
                title: 'Syncing',
                html: '<img width=40 src="https://gifimage.net/wp-content/uploads/2018/04/loader-gif-transparent-background-11.gif"/><div class="progress">' +

                    '<div class="progress-meter" style="width:0%"></div>' +
                    '</div >' +
                    '<span class="progress-val">0%</span> complete ',
                allowOutsideClick: false


            });
        }
    })

};

function startRuleSyncC() {
    Swal.fire({
        title: '<strong>Do not Close this window</strong>',
        type: 'info',
        html:
            'Closing this window may cause loss in the data',
        showCloseButton: true,
        showCancelButton: true,
        focusConfirm: false,
        confirmButtonText:
            'Start',
        confirmButtonAriaLabel: 'Start!',
        cancelButtonText:
            'Cancel',
        cancelButtonAriaLabel: 'Thumbs down',
    }).then((result) => {
        if (result.value) {
            //truncateData_start_syncing();
            truncateRulesData_start_syncingC();
            Swal.fire({

                showCancelButton: false,
                showConfirmButton: false,
                title: 'Syncing',
                html: '<img width=40 src="https://gifimage.net/wp-content/uploads/2018/04/loader-gif-transparent-background-11.gif"/><div class="progress">' +

                    '<div class="progress-meter" style="width:0%"></div>' +
                    '</div >' +
                    '<span class="progress-val">0%</span> complete ',
                allowOutsideClick: false


            });
        }
    })

};

function truncateIndividualsData_start_syncing() {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/truncate_Individual_data",
        contentType: "application/json; charset=utf-8",
        data: '{ }',
        success: function (msg) {

            start_Individual_recursive_hits(1, 1000);

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }


    });

};


function truncateProfileData_start_syncing() {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/truncate_profile_data",
        contentType: "application/json; charset=utf-8",
        data: '{ }',
        success: function (msg) {

            start_profile_recursive_hits(1, 1000);

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }


    });
};

function truncateCorporateData_start_syncing(pageNumber, pageSize, caler) {

    let model = {
        pageNumber: pageNumber, pageSize: pageSize, caler: caler
    };

    $.ajax({
        type: "POST",
        url: "/SystemSetting/CorporateData",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(model),
        success: function (msg) {
            

            if (msg == "YES") {
                truncateCorporateData_start_syncing(pageNumber + 1, pageSize, caler);
            }

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
};

function truncateAssetsData_start_syncing(pageNumber, pageSize, caler) {

    let model = {
        pageNumber: pageNumber, pageSize: pageSize, caler: caler
    };

    $.ajax({
        type: "POST",
        url: "/SystemSetting/AssetsData",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(model),
        success: function (msg) {
            

            if (msg == "YES") {
                truncateAssetsData_start_syncing(pageNumber + 1, pageSize, caler);
            }

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
};

function truncateRulesData_start_syncing(pageNumber, pageSize, caler) {
    let model = {
        pageNumber: pageNumber, pageSize: pageSize, caler: caler
    };

    $.ajax({
        type: "POST",
        url: "/SystemSetting/RulesData",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(model),
        success: function (msg) {

            if (msg == "YES") {
                truncateRulesData_start_syncing(pageNumber + 1, pageSize, caler);
            }

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });

};

//truncate items data
function truncateItemsData_start_syncing(pageNumber, pageSize, caler) {
    
    let model = {
        pageNumber: pageNumber, pageSize: pageSize, caler: caler
    };

    $.ajax({
        type: "POST",
        url: "/SystemSetting/ItemsData",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(model),
        success: function (msg) {

            if (msg == "YES") {
                truncateItemsData_start_syncing(pageNumber + 1, pageSize, caler);
            }

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });

};

function start_Individual_recursive_hits(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/IndividualcheckProgress",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);





            if (nextPage == "Yes") {
                start_Individual_recursive_hits(pageNumber + 1, pageSize);
            } else {
                var percentage = 100;
                $('.progress-meter').stop();
                var $el = $('.progress-val');
                $('.progress-meter').animate({

                    width: percentage + '%'
                }, {
                    duration: 5000,
                    step: function (now, fx) {
                        if (fx.prop == 'width') { //If you animate more than 1 property
                            var data = Math.round(now);
                            $el.text(data + ' % ');
                        }

                    },
                    done: function () {
                        Swal.fire(
                            'Syncing Successful',
                            'Data Successfully Synced Count :' + totRecord,
                            'success'
                        )
                    }
                });
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val')
    $('.progress-meter').stop(true).animate({

        width: percentage + '%'
    }, {
        duration: 15000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });
};

function start_profile_recursive_hits(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/ProfilecheckProgress",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);





            if (nextPage == "Yes") {
                start_profile_recursive_hits(pageNumber + 1, pageSize);
            } else {
                var percentage = 100;
                $('.progress-meter').stop();
                var $el = $('.progress-val');
                $('.progress-meter').animate({

                    width: percentage + '%'
                }, {
                    duration: 5000,
                    step: function (now, fx) {
                        if (fx.prop == 'width') { //If you animate more than 1 property
                            var data = Math.round(now);
                            $el.text(data + ' % ');
                        }

                    },
                    done: function () {
                        Swal.fire(
                            'Syncing Successful',
                            'Data Successfully Synced Count :' + totRecord,
                            'success'
                        )
                    }
                });
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val')
    $('.progress-meter').stop(true).animate({

        width: percentage + '%'
    }, {
        duration: 15000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });
};

function start_profile_recursive_hitsB(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/ProfilecheckProgressB",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);





            if (nextPage == "Yes") {
                start_profile_recursive_hitsB(pageNumber + 1, pageSize);
            } else {
                var percentage = 100;
                $('.progress-meter').stop();
                var $el = $('.progress-val');
                $('.progress-meter').animate({

                    width: percentage + '%'
                }, {
                    duration: 5000,
                    step: function (now, fx) {
                        if (fx.prop == 'width') { //If you animate more than 1 property
                            var data = Math.round(now);
                            $el.text(data + ' % ');
                        }

                    },
                    done: function () {
                        Swal.fire(
                            'Syncing Successful',
                            'Data Successfully Synced Count :' + totRecord,
                            'success'
                        )
                    }
                });
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val')
    $('.progress-meter').stop(true).animate({

        width: percentage + '%'
    }, {
        duration: 15000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });
};
function start_profile_recursive_hitsC(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/ProfilecheckProgressC",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);





            if (nextPage == "Yes") {
                start_profile_recursive_hitsC(pageNumber + 1, pageSize);
            } else {
                var percentage = 100;
                $('.progress-meter').stop();
                var $el = $('.progress-val');
                $('.progress-meter').animate({

                    width: percentage + '%'
                }, {
                    duration: 5000,
                    step: function (now, fx) {
                        if (fx.prop == 'width') { //If you animate more than 1 property
                            var data = Math.round(now);
                            $el.text(data + ' % ');
                        }

                    },
                    done: function () {
                        Swal.fire(
                            'Syncing Successful',
                            'Data Successfully Synced Count :' + totRecord,
                            'success'
                        )
                    }
                });
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val')
    $('.progress-meter').stop(true).animate({

        width: percentage + '%'
    }, {
        duration: 15000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });
};



function start_Assets_recursive_hits(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/AssetcheckProgress",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);





            if (nextPage == "Yes") {
                start_Assets_recursive_hits(pageNumber + 1, pageSize);
            } else {
                var percentage = 100;
                $('.progress-meter').stop();
                var $el = $('.progress-val');
                $('.progress-meter').animate({

                    width: percentage + '%'
                }, {
                    duration: 5000,
                    step: function (now, fx) {
                        if (fx.prop == 'width') { //If you animate more than 1 property
                            var data = Math.round(now);
                            $el.text(data + ' % ');
                        }

                    },
                    done: function () {
                        Swal.fire(
                            'Syncing Successful',
                            'Data Successfully Synced Count :' + totRecord,
                            'success'
                        )
                    }
                });
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val')
    $('.progress-meter').stop(true).animate({

        width: percentage + '%'
    }, {
        duration: 15000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });

};
function start_Assets_recursive_hitsB(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/AssetcheckProgressB",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);





            if (nextPage == "Yes") {
                start_Assets_recursive_hitsB(pageNumber + 1, pageSize);
            } else {
                var percentage = 100;
                $('.progress-meter').stop();
                var $el = $('.progress-val');
                $('.progress-meter').animate({

                    width: percentage + '%'
                }, {
                    duration: 5000,
                    step: function (now, fx) {
                        if (fx.prop == 'width') { //If you animate more than 1 property
                            var data = Math.round(now);
                            $el.text(data + ' % ');
                        }

                    },
                    done: function () {
                        Swal.fire(
                            'Syncing Successful',
                            'Data Successfully Synced Count :' + totRecord,
                            'success'
                        )
                    }
                });
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val')
    $('.progress-meter').stop(true).animate({

        width: percentage + '%'
    }, {
        duration: 15000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });

};
function start_Assets_recursive_hitsC(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/AssetcheckProgressC",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);





            if (nextPage == "Yes") {
                start_Assets_recursive_hitsC(pageNumber + 1, pageSize);
            } else {
                var percentage = 100;
                $('.progress-meter').stop();
                var $el = $('.progress-val');
                $('.progress-meter').animate({

                    width: percentage + '%'
                }, {
                    duration: 5000,
                    step: function (now, fx) {
                        if (fx.prop == 'width') { //If you animate more than 1 property
                            var data = Math.round(now);
                            $el.text(data + ' % ');
                        }

                    },
                    done: function () {
                        Swal.fire(
                            'Syncing Successful',
                            'Data Successfully Synced Count :' + totRecord,
                            'success'
                        )
                    }
                });
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val')
    $('.progress-meter').stop(true).animate({

        width: percentage + '%'
    }, {
        duration: 15000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });

};


//hitting syncing API recursivly for rules
function start_Rules_recursive_hits(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/rulesCheckProgress",
        timeout: 1800000,
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {
            console.log("completed syncing")
            var percentage = 100;
            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            $('.progress-meter').stop();
            var $el = $('.progress-val');
            $('.progress-meter').animate({

                width: percentage + '%'
            }, {
                duration: 5000,
                step: function (now, fx) {
                    if (fx.prop == 'width') { //If you animate more than 1 property
                        var data = Math.round(now);
                        $el.text(data + ' % ');
                    }

                },
                done: function () {
                    Swal.fire(
                        'Syncing Successful',
                        'Data Successfully Synced Count :' + totRecord,
                        'success'
                    )
                }
            });
            // if (nextPage == "Yes") {
            //    start_Rules_recursive_hits(pageNumber + 1, pageSize);
            // } else {

            //}



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val');
    $('.progress-meter').animate({

        width: percentage + '%'
    }, {
        duration: 250000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });

};

function start_Rules_recursive_hitsB(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/rulesCheckProgressB",
        timeout: 1800000,
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {
            console.log("completed syncing")
            var percentage = 100;
            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            $('.progress-meter').stop();
            var $el = $('.progress-val');
            $('.progress-meter').animate({

                width: percentage + '%'
            }, {
                duration: 5000,
                step: function (now, fx) {
                    if (fx.prop == 'width') { //If you animate more than 1 property
                        var data = Math.round(now);
                        $el.text(data + ' % ');
                    }

                },
                done: function () {
                    Swal.fire(
                        'Syncing Successful',
                        'Data Successfully Synced Count :' + totRecord,
                        'success'
                    )
                }
            });

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val');
    $('.progress-meter').animate({

        width: percentage + '%'
    }, {
        duration: 250000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });

    /*$({percentage: parseInt($('.progress-val').text(), 10) }).stop(true).animate({percentage: value }, {
    duration: 150000,
easing: "easeOutExpo",
step: function () {
            // percentage with 1 decimal;
            var percentageVal = Math.round(this.percentage * 10) / 10;

$el.text(percentageVal + '%');

        }
    }).promise().done(function () {
    // hard set the value after animation is done to be

    // $el.text(value + "%");


});*/

};

function start_Rules_recursive_hitsC(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/rulesCheckProgressC",
        timeout: 1800000,
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {
            console.log("completed syncing")
            var percentage = 100;
            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            $('.progress-meter').stop();
            var $el = $('.progress-val');
            $('.progress-meter').animate({

                width: percentage + '%'
            }, {
                duration: 5000,
                step: function (now, fx) {
                    if (fx.prop == 'width') { //If you animate more than 1 property
                        var data = Math.round(now);
                        $el.text(data + ' % ');
                    }

                },
                done: function () {
                    Swal.fire(
                        'Syncing Successful',
                        'Data Successfully Synced Count :' + totRecord,
                        'success'
                    )
                }
            });
            // if (nextPage == "Yes") {
            //    start_Rules_recursive_hits(pageNumber + 1, pageSize);
            // } else {

            //}



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });
    var percentage = 60;
    var $el = $('.progress-val');
    $('.progress-meter').animate({

        width: percentage + '%'
    }, {
        duration: 250000,
        step: function (now, fx) {
            if (fx.prop == 'width') { //If you animate more than 1 property
                var data = Math.round(now);
                $el.text(data + ' % ');
            }
        }
    });

    /*$({percentage: parseInt($('.progress-val').text(), 10) }).stop(true).animate({percentage: value }, {
    duration: 150000,
easing: "easeOutExpo",
step: function () {
            // percentage with 1 decimal;
            var percentageVal = Math.round(this.percentage * 10) / 10;

$el.text(percentageVal + '%');

        }
    }).promise().done(function () {
    // hard set the value after animation is done to be

    // $el.text(value + "%");


});*/

};


//hitting syncing API recursivly for items
function start_recursive_hits(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/checkProgress",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);



            var $el = $('.progress-val'),
                value = percentage;
            $('.progress-meter').stop(true).animate({

                width: percentage + '%'
            }, {
                duration: 15000,
                progress: function (promise, progress, ms) {
                    var val = Math.round(progress * 100) + '%';


                }
            });

            $({ percentage: parseInt($('.progress-val').text(), 10) }).stop(true).animate({ percentage: value }, {
                duration: 25000,
                easing: "easeOutExpo",
                step: function () {
                    // percentage with 1 decimal;
                    var percentageVal = Math.round(this.percentage * 10) / 10;

                    $el.text(percentageVal + '%');

                }
            }).promise().done(function () {
                // hard set the value after animation is done to be

                // $el.text(value + "%");

            });






            if (nextPage == "Yes") {
                start_recursive_hits(pageNumber + 1, pageSize);
            } else {
                Swal.fire(
                    'Syncing Successful',
                    'Data Successfully Synced Count :' + totRecord,
                    'success'
                )
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });

};

function start_recursive_hitsB(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/checkProgressB",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);



            var $el = $('.progress-val'),
                value = percentage;
            $('.progress-meter').stop(true).animate({

                width: percentage + '%'
            }, {
                duration: 15000,
                progress: function (promise, progress, ms) {
                    var val = Math.round(progress * 100) + '%';


                }
            });

            $({ percentage: parseInt($('.progress-val').text(), 10) }).stop(true).animate({ percentage: value }, {
                duration: 25000,
                easing: "easeOutExpo",
                step: function () {
                    // percentage with 1 decimal;
                    var percentageVal = Math.round(this.percentage * 10) / 10;

                    $el.text(percentageVal + '%');

                }
            }).promise().done(function () {
                // hard set the value after animation is done to be

                // $el.text(value + "%");

            });






            if (nextPage == "Yes") {
                start_recursive_hits(pageNumber + 1, pageSize);
            } else {
                Swal.fire(
                    'Syncing Successful',
                    'Data Successfully Synced Count :' + totRecord,
                    'success'
                )
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });

};

function start_recursive_hitsC(pageNumber, pageSize) {
    $.ajax({
        type: "POST",
        url: "PullData_N.aspx/checkProgressC",
        contentType: "application/json; charset=utf-8",
        data: '{pageNumber:' + pageNumber + ',pageSize: ' + pageSize + ' }',
        success: function (msg) {

            var json = $.parseJSON(msg.d);
            var currentPage = json.currentPage;
            var totalPages = json.totalPages;
            var nextPage = json.nextPage;
            var totRecord = json.totalCount;
            var percentage = ((currentPage * 100) / totalPages);



            var $el = $('.progress-val'),
                value = percentage;
            $('.progress-meter').stop(true).animate({

                width: percentage + '%'
            }, {
                duration: 15000,
                progress: function (promise, progress, ms) {
                    var val = Math.round(progress * 100) + '%';


                }
            });

            $({ percentage: parseInt($('.progress-val').text(), 10) }).stop(true).animate({ percentage: value }, {
                duration: 25000,
                easing: "easeOutExpo",
                step: function () {
                    // percentage with 1 decimal;
                    var percentageVal = Math.round(this.percentage * 10) / 10;

                    $el.text(percentageVal + '%');

                }
            }).promise().done(function () {
                // hard set the value after animation is done to be

                // $el.text(value + "%");

            });






            if (nextPage == "Yes") {
                start_recursive_hits(pageNumber + 1, pageSize);
            } else {
                Swal.fire(
                    'Syncing Successful',
                    'Data Successfully Synced Count :' + totRecord,
                    'success'
                )
            }



        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(XMLHttpRequest);
            var json = $.parseJSON(XMLHttpRequest.responseText);
            console.log(json);
            Swal.fire(
                '(' + XMLHttpRequest.status + ' )' + errorThrown,
                json.Message,
                'error'
            )
        }

    });

};