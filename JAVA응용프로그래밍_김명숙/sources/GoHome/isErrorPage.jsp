<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8" isErrorPage="true" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h2>서비스 중 일시적인 오류가 발생하였습니다.</h2>
    <p>
        오류명 : <%= exception.getClass().getName() %>
        <br>
        오류 메시지 : <%= exception.getMessage() %>
    </p>
</body>
</html>