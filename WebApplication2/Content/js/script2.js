$(document).ready(function(){
	$('.thumb').on({
		mouseenter: function(){
			$(this).find('.chitiet').css("display", "block");
		}, 
		mouseleave: function(){
			$(this).find('.chitiet').css("display", "none");
		}
	});
	//Thay doi anh trang chi tiet
	$('.anhchitiet').click(function () {
		var src = $(this).attr("src");
		$('.anhsanpham').attr("src",src);
		var ez= $("#zoom_01").data('elevateZoom');
		ez.swaptheimage(src, src);
	});
	$("#zoom_01").elevateZoom();
});
$(document).ready(function()
{
	$('.banner3').mouseover(function(){
		$(this).css('background-size','105%');
	});
	$('.banner3').mouseleave(function(){
		$(this).css('background-size','100%');

	});
});
$(document).ready(function() {
	$('li.minus').click(function() {
		var x = parseInt($('.qty').find('input').val());
		if(isNaN(x))
		{
			$('.qty').find('input').val(1);
		}
		if(!isNaN(x) && x>1)
		{
			$('.qty').find('input').val(x-1);
		}
	});
	$('li.add').click(function() {
		var x = parseInt($('.qty').find('input').val());
		if(isNaN(x))
		{
			$('.qty').find('input').val(1);
		}
		if(!isNaN(x))
		{
			$('.qty').find('input').val(x+1);
		}
	});
});
$(document).ready(function() {
	$('.selected-size').click(function(){
		$('.selected-size').removeClass('active');
		$(this).addClass('active');
	})
});
$(document).ready(function() {
	$('.selected-image').click(function(){
		$('.selected-image').removeClass('active');
		$(this).addClass('active');
	})
});

$(document).ready(function(){
	$('a[data-toggle="modal"]').click(function(){
		var url = $(this).parent().parent().parent().css('background-image');
		if (sessionStorage["url"] + "" == "undefined"){
			sessionStorage["url"]="";
		}
		if((sessionStorage["url"]).indexOf(url) == -1)
		{
			sessionStorage["url"] += url + "~";
		}
		$('.Popup').html("");
		var string = sessionStorage["url"];
		arrayImg =new Array();
		arrayImg = string.split('~');
		for(var i = 0 ; i < arrayImg.length; i++)
		{
			if(arrayImg[i]!= ""){
				var img = arrayImg[i];
				img = img.replace("url(","");
				img = img.replace(")","");
				$('.Popup').append("<a href='chitietsanpham.html'><img src ="+img+" width=50 height=50 ></a>");
			}
		}

	});
});

$(document).ready(function(){
	
});