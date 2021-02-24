var modal;

$(function () {

    modal = new abp.ModalManager({
        viewUrl: '/ChildPage'
    });

    $("#openModal").click(function(){

        modal.open();

    })
    modal.onResult(res=>{
        alert(res);
    })

    abp.log.debug('Index.js initialized!');
});
