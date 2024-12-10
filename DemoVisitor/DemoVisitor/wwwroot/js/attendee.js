
const data = typeof jsonData !== 'undefined' ? jsonData : [];

if (data.length > 0) {
    generateTemplate(data);
    console.table(data)
}

let lastId = getLastId(data);


function generateTemplate(data) {
    data.forEach(item => {
        const template = createTemplate(item.Id, item.ContentText, item.ContentType, item.locationIds);
        switch (item.ContentType) {
            case 4:
                $('#tbodyCheckInOnKiosk').append(template);
                break;
            case 5:
                $('#tbodyCheckInAtReception').append(template);
                break;
            default:
                break;
        }
    });
}


function createTemplate(id = '', contentText = '', contentType = '',locationIds = '') {
    return `
        <tr id='${id}'>
            
            <td>
                <textarea class="text-area-contenttext" style="width: 520px">${contentText}</textarea>
            </td>
            <td>
                <textarea>${locationIds}</textarea>
            </td>
            <td>
                <span class="btn btn-primary">...</span>
            </td>
            <td>
                <span class="btn btn-primary">Language</span>
            </td>
            <td>
                <span class="btn btn-danger btn-remove" data-id="${id}">Remove</span>
            </td>
        </tr>`;
}


$('#btnAddCheckInOnKiosk').on('click', function () {
    lastId = lastId + 1; 
    const newRow = createTemplate(lastId, '', 4); 
    $('#tbodyCheckInOnKiosk').append(newRow); 
});

$('#btnAddCheckInAtReception').on('click', function () {
    lastId = lastId + 1; 
    const newRow = createTemplate(lastId, '', 5); 
    $('#tbodyCheckInAtReception').append(newRow); 
});


function getLastId(data) {
    const sortedData = data.sort((a, b) => b.Id - a.Id);
    return sortedData.length > 0 ? sortedData[0].Id : 0;
}


$(document).on('click', '.btn-remove', function () {
    const id = $(this).data('id');
    removeRow(id);
});

function removeRow(id) {
    $(`#${id}`).remove();
}

$('#btnSave').on('click', function () {
    const updatedData = [];

    $('#tbodyCheckInOnKiosk tr').each(function () {
        const id = $(this).attr('id');
        const contentText = $(this).find('textarea').eq(0).val();
        updatedData.push({
            Id: parseInt(id),
            ContentType: 4,
            ContentText: contentText,
            LocationIds: '1,2,3',
        });
    });

    $('#tbodyCheckInAtReception tr').each(function () {
        const id = $(this).attr('id');
        const contentText = $(this).find('textarea').eq(0).val();
        updatedData.push({
            Id: parseInt(id),
            ContentType: 5,
            ContentText: contentText,
            LocationIds: '1,2,3',
        });
    });

    saveData(updatedData);
});

function saveData(data) {
    $.ajax({
        url: '/Home/Save',  
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(data), 
        success: function (response) {
            alert("Data saved successfully!");
        },
        error: function (xhr, status, error) {
            alert("An error occurred while saving data.");
        }
    });
}