

function survey() {
    var inner = "Question: <input type=text name=QuestionOne id=QuestionOne required/><br/ > <br />\
    Answer Type: <select name=typeOne id=typeOne>\
<option value=default selected>Select Option</option >\
<option value=Text>Text Response</option>\
<option value=Rating>Rating Response</option>\
</select > <br /> <br />"
    document.getElementById("survey").innerHTML = inner;
}