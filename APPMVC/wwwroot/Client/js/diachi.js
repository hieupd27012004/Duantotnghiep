$(document).ready(function () {
    // Khi tỉnh được chọn
    $("#ProvinceId").change(function () {
        var provinceId = $(this).val();
        console.log("ProvinceId:", provinceId);
        if (provinceId) {
            $.get('@Url.Action("GetDistricts", "DiaChi", new { area = "Client" })?provinceId=' + provinceId, function (data) {
                $("#DistrictId").empty().append('<option value="">Chọn Quận/Huyện</option>');
                $.each(data, function (i, item) {
                    $("#DistrictId").append('<option value="' + item.districtId + '">' + item.districtName + '</option>');
                });
            });
        }
    });

    // Khi quận được chọn
    $("#DistrictId").change(function () {
        var districtId = $(this).val();
        if (districtId) {
            $.get('@Url.Action("GetWards", "DiaChi", new { area = "Client" })?districtId=' + districtId, function (data) {
                $("#WardId").empty().append('<option value="">Chọn Phường/Xã</option>');
                $.each(data, function (i, item) {
                    $("#WardId").append('<option value="' + item.wardId + '">' + item.wardName + '</option>');
                });
            });
        }
    });
});