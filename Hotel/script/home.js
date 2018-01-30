//  var a = document.getElementById("login_mask");
function closeAll() {
    document.getElementById("login_mask").classList.remove("show");
    document.getElementById("login_mask").classList.add("hide");
    //  a.classList.add("hide");
}
function showLog() {
    // alert("jdfsfldf");
    document.getElementById("sign_mask").classList.add("hide");
    document.getElementById("login_mask").classList.remove("hide");
    document.getElementById("login_mask").classList.add("show");
    document.getElementById("sign_mask").classList.remove("show");


}
/////////////Login////////////////////////
function showsign() {
    document.getElementById("login_mask").classList.remove("show");
    document.getElementById("login_mask").classList.add("hide");
    document.getElementById("sign_mask").classList.remove("hide");
    document.getElementById("sign_mask").classList.add("show");
}
function closeAlll() {
    //  a.classList.add("hide");
    document.getElementById("sign_mask").classList.remove("show");
    document.getElementById("sign_mask").classList.add("hide");
}