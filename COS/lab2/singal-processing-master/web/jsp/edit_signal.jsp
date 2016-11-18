<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%--
  Created by IntelliJ IDEA.
  User: Антон
  Date: 24.10.2016
  Time: 3:36
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Edit signal</title>
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link type="text/css" rel="stylesheet" href="${pageContext.request.contextPath}/css/styles.css"
          media="screen,projection"/>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="${pageContext.request.contextPath}/js/bin/materialize.min.js"></script>
</head>
<body>
<c:import url="header.jsp"/>
<main>
    <div class="wrapper">
        <div class="container">
            <div class="row">
                <div class="col s8 offset-s2">
                    <div class="card z-depth-4">
                        <div class="card-content">
                            <span class="card-title text-darken-2">Signal</span>
                            <form action="${pageContext.request.contextPath}/controller" method="POST">
                                <c:if test="${not empty sessionScope.signal}">
                                    <input type="hidden" name="command" value="update_signal">
                                    <input type="hidden" name="signal_id" value="${sessionScope.signal.signalId}">
                                </c:if>
                                <c:if test="${empty sessionScope.signal}">
                                    <input type="hidden" name="command" value="create_signal">
                                </c:if>

                                <div class="row">
                                    <div class="input-field col s12">
                                        <input id="id-amplitude" type="text" name="amplitude"
                                               value="${sessionScope.signal.amplitude}"
                                               required>
                                        <label for="id-amplitude">Amplitude (A)</label>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="input-field col s12">
                                        <input id="id-phase" type="text" name="phase"

                                               value="${sessionScope.signal.phase}" required>
                                        <label for="id-phase">Phase (Phi)</label>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="input-field col s12">
                                        <input id="id-frequency" type="text" name="frequency"

                                               value="${sessionScope.signal.frequency}" required>
                                        <label for="id-amplitude">Frequency (w)</label>
                                    </div>
                                </div>


                                <div class="card-action">
                                    <div class="row">
                                        <button class="btn col s12 black" type="submit">Save</button>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <c:if test="${not empty requestScope.message}">
        <script>Materialize.toast(${requestScope.message}, 4000)</script>
    </c:if>
</main>
</body>
</html>
