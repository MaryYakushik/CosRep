<%--
  Created by IntelliJ IDEA.
  User: Антон
  Date: 08.08.2016
  Time: 11:27
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Header</title>
</head>
<body>

<nav>
    <div class="nav-wrapper black">
        <ul class="left hide-on-med-and-down">
            <li>
                <form name="all_signals" action="${pageContext.request.contextPath}/controller" method="POST">
                    <input type="hidden" name="command" value="find_all_signals">
                    <a href="javascript:document.all_signals.submit()">All signals</a>
                </form>
            </li>
        </ul>
    </div>

</nav>

</body>
</html>
