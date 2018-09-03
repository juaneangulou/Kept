﻿var dataAssesstment = [];
$(document).ready(function () {
    $(".yesbtnclass").click(function () {
        let attrIdQuestion = this.getAttribute("attrIdQuestion");
        let attrCAndPId = this.getAttribute("attrCAndPId");
        SetAnswer(attrIdQuestion, attrCAndPId, 1);
        $(this).removeClass("btn-default").addClass("btn-success");
    });

    $(".nobtnclass").click(function () {
        let attrIdQuestion = this.getAttribute("attrIdQuestion");
        let attrCAndPId = this.getAttribute("attrCAndPId");
        SetAnswer(attrIdQuestion, attrCAndPId, 0);
        $(this).removeClass("btn-default").addClass("btn-danger");
    });
});

function SetAnswer(attrIdQuestion, attrCAndPId, SelfScore, SelfComments) {
    let record = getNewItem();
    record.QuestionId = attrIdQuestion;
    record.SelfScore = SelfScore;
    record.SelfComments = SelfComments;
    record.attrCAndPId = attrCAndPId;
    let search = dataAssesstment.filter((x) => {
        return x.QuestionId === attrIdQuestion;
    });

    if (search.length === 0) {
        dataAssesstment.push(record);
    } else {
        let objIndex = dataAssesstment.findIndex((obj => obj.QuestionId === record.QuestionId));
        dataAssesstment[objIndex] = record;
    }
    updateTotal(attrCAndPId)
}
function getNewItem() {
    return {
        "AssessmentId": 0,
        "CompletedDate": moment(),
        "QuestionId": 0,
        "Score": 0,
        "EmployeeDocumentId": "",
        "SelfScore": 0,
        "SelfComments": "",
        "attrCAndPId":0
    };
}

function updateTotal(attrCAndPId) {
    let result = dataAssesstment.filter((x) => {
        return (x.attrCAndPId === attrCAndPId);
    });
    $("#total_" + attrCAndPId).html(result.length);
}