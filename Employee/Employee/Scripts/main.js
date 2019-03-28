function onSubmit() {
    var id = $("#id").val().trim();
    if (id == '') {
        alert("Id field cannot be blank");
        return false;
    }
    var name = $("#name").val().trim();
    if (name == '') {
        alert("Name field cannot be blank");
        return false;
    }
    var address = $("#address").val().trim();
    var city = $("#city").val().trim();
    var state = $("#state").val().trim();
    return validateCity();
}

function validateCity() {
    var inputVal = $("#city").val().toUpperCase();
    var characterReg = /^[0-9a-zA-Z]+$/;
    if (!characterReg.test(inputVal)) {
        alert("No special characters allowed.");
        return false;
    }
    else if (inputVal.match(/CITY/g)) {
        alert('Word city is not allowed in the City field');
        return false;
    }
    else {
        return true;
    }
}

function NotCAEmployee(result) {
    if (result == "false")
        alert("Only Califoirnia employees can be saved in the database");
    else
        alert("Employee was successfully saved in the database");
}