let selection = null;

function selectionChanged(selectedItems) {
    selection = selectedItems.selectedRowsData[0];
}

function showPopUp() {
    $("#editPopUp")
        .dxPopup("instance")
        .option("visible", true);
    $("#form")
        .dxForm("instance")
        .option("formData", selection);
    $("#form")
        .dxForm("instance")
        .updateData("Id", selection.ID);
}