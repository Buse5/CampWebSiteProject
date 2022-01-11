function FormCheck(){
  var Username = document.querySelector(".Username");
  var Password = document.querySelector(".Password");
  var Submit = document.querySelector(".Submit");
  var Submitbtn = document.querySelector(".Submitbtn");
  if(Username.value.length >= 7){
    if(Password.value.length >= 7){
      Submit.style.width = "50px";
      Submit.style.height = "50px";
      Submit.style.margin = "auto";
      Submit.style.padding = "0px";
      Submit.style.borderRadius = "50%";
      Submit.disabled = true;
      Submit.innerHTML = "<span class='login'></span>";
      return false;
    }else{
      Password.style.borderBottom = "1px solid #8f0000";
      Password.focus();
      return false;
    }
  }else{
    Username.style.borderBottom = "1px solid #8f0000";
    Username.focus();
    return false;
  }
}