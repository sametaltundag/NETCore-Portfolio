function openEditModal(skillId) {
    // AJAX isteği yap
    $.ajax({
        url: '/Skill/GetById/' + skillId,
        type: 'GET',
        success: function (response) {
            // Gelen verilerle modalı doldur
            $('#editTitle').val(response.title);
            $('#editValue').val(response.value);
            $('#editSkillId').val(skillId); // Hidden input'un değerini ayarla
            // Modalı aç
            $('#duzenleModal').modal('show');
        },
        error: function (error) {
            console.log(error);
        }
    });
}

// Kaydet butonuna basıldığında
$('#duzenleModal').on('submit', 'form', function (e) {
    e.preventDefault(); // Sayfanın yeniden yüklenmesini engelle

    var formData = $(this).serialize(); // Form verilerini al
    var url = $(this).attr('action'); // Formun gönderileceği URL

    // AJAX isteği yap
    $.post(url, formData)
        .done(function (response) {
            // Başarılı bir şekilde işlem yapıldığında modalı kapat
            $('#duzenleModal').modal('hide');
            // İlgili sayfayı yeniden yükle
            window.location.reload();
        })
        .fail(function (error) {
            console.log(error);
        });
});