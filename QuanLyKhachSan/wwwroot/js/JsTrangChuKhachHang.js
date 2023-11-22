
    $(document).ready(function () {
        $('.room-type').each(function () {
            var maPhong = $(this).attr('id');
            fetchRoomType(maPhong, this);
        });
        });

    function fetchRoomType(maPhong, element) {
        $.ajax({
            url: '/TrangChuKhachHang/LayLoaiPhong',
            type: 'GET',
            data: { maPhong: maPhong },
            success: function (data) {
                $(".loaiPhong").text(data.tenLoaiPhong);
                $("#loaiPhong-" + maPhong).text("Loại phòng: " + data.tenLoaiPhong);

                $("#price-" + maPhong).text("Giá theo giờ: " + data.giaTheoGio + "  |  " + "Giá theo ngày: " + data.giaPhongTheoNgay);
                $("#soLuongNguoi-" + maPhong).text("Số lượng người lớn: " + data.soLuongNguoiLon + "  |  " + "Số lượng trẻ em: " + data.soLuongTreEm);
                $("#phuThuTraMuon-" + maPhong).text("Phụ thu trả muộn: " + data.phuThuTraMuon + "/1 ngày");


                console.log(data.tenLoaiPhong);
            }
        });
 }
