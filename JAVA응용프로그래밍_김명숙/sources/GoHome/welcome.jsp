<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<html>

<head>
    <title>페이지 이름</title>
</head>

<body>
    <h1>안녕하세요요용</h1>
    <hr>
    <p>그래 안녕</p>
    <%
    int sum = 0;
    for(int i=1; i<=10; i++){
        sum += i;
    }
    out.print("합은: " + sum);
    out.print("<br>");
    %>

    합은 : <%= sum %>
</body>

</html>