<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import ="java.text.SimpleDateFormat, java.util.Date"%>
<!-- <%@ page import ="java.util.Date"%> -->
<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <title>title name</title>
</head>
<body>
<%
    Date today = new Date();
    SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd/hh-mm-ss");
    String todayStr = dateFormat.format(today);
    out.println("오늘 날짜 : " + todayStr);
%>
</body>
</html>