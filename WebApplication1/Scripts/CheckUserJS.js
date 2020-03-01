$("#buttonSender").click(
function(e) {
    //если type=submit  то e.preventDefault()
    const nik=$("input[name='Nik']").val();
    if (nik.length == 0) {
        alert('Nickname required');
        return;
    }
    const realName = $("input[name='RealName']").val();
    if (realName.length == 0) {
        alert('Real name required');
        return;
    }
    var regexPerson = /^[a - zA - Z] + (([',. -][a-zA-Z ])?[a-zA-Z]*)*$/g;   
   
    if (!regexPerson.test(realName)) {
        alert('Real name is invalid');
        return;
    }
    const pass1 = $("input[name='PassHash']").val();
    const pass2 = $("input[name='rePassword']").val();
    //if(pass1.

    e.target.closest("form").submit();
});
