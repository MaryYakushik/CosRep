<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>

<%--
  Created by IntelliJ IDEA.
  User: Антон
  Date: 24.10.2016
  Time: 3:37
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>All signals</title>
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link type="text/css" rel="stylesheet" href="${pageContext.request.contextPath}/css/styles.css"
          media="screen,projection"/>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="${pageContext.request.contextPath}/js/bin/materialize.min.js"></script>
    <script type="text/javascript" src="${pageContext.request.contextPath}/js/plotly-latest.min.js"></script>

    <script>
        $(document).ready(function () {
            $.ajax({
                url: 'jsoncontroller',
                type: 'get',
                dataType: 'json',
                data: {command: "draw_graph"},
                success: function (json) {
                    deleteAllTraces('graph');
                    Plotly.plot('graph', json[0], {margin: {t: 0}});
                    Plotly.plot('polyharmonic-graph', json[1], {margin: {t: 0}});
                    Plotly.plot('fourie-freq', json[2], {margin: {t: 0}});
                    Plotly.plot('fourie-phase', json[3], {margin: {t: 0}});
                    Plotly.plot('fourie-akf', json[4], {margin: {t: 0}});
                    Plotly.plot('fourie-inverse', json[5], {margin: {t: 0}});
                }
            });

        });
    </script>

    <script>
        function deleteAllTraces(graphId) {
            try {
                while (true) {
                    Plotly.deleteTraces(graphId, 0);
                }
            } catch (err) {
                console.log(err);
            }
        }
    </script>
</head>
<body>
<c:import url="header.jsp"/>
<div class="wrapper">
    <div class="container">
        <div class="row">
            <div class="col s8 offset-s2">
                <div class="card z-depth-4">
                    <div class="card-content">
                        <span class="card-title">All signals</span>
                        <c:if test="${not empty sessionScope.signal_list}">
                            <ul class="collection">
                                <c:forEach items="${sessionScope.signal_list}" var="signal">
                                    <li class="collection-item avatar">
                                        <i class="material-icons circle black small">equalizer</i>
                                        <p>
                                            <b>Amplitude (A) :</b> ${signal.amplitude}<br>
                                            <b>Phase (fi) :</b> ${signal.phase}<br>
                                            <b>Frequency (w) :</b> ${signal.frequency}<br>
                                        </p>
                                        <div class="secondary-content">
                                            <div style="float: left">
                                                <form action="${pageContext.request.contextPath}/controller"
                                                      method="POST">
                                                    <input type="hidden" name="command"
                                                           value="find_signal_for_update">
                                                    <input type="hidden" name="signal_id" value="${signal.signalId}">
                                                    <button class="btn-floating black" type="submit">
                                                        <i class="material-icons">mode_edit</i>
                                                    </button>
                                                </form>
                                            </div>
                                            <div style="float: right">
                                                <form action="${pageContext.request.contextPath}/controller"
                                                      method="POST">
                                                    <input type="hidden" name="command" value="delete_signal">
                                                    <input type="hidden" name="signal_id" value="${signal.signalId}">
                                                    <button class="btn-floating red" type="submit">
                                                        <i class="material-icons">delete</i>
                                                    </button>
                                                </form>
                                            </div>
                                        </div>
                                    </li>
                                </c:forEach>
                            </ul>
                        </c:if>
                        <div class="card-action">
                            <div class="row">
                                <form action="${pageContext.request.contextPath}/controller" method="POST">
                                    <input type="hidden" name="command" value="find_signal_for_create">
                                    <button class="btn col s12 black" type="submit">
                                        <i class="material-icons">add</i>
                                    </button>
                                </form>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <h2>Graphs</h2>
    <div id="graph" class="graph"></div>
    <h2>Polyharmonic graph</h2>
    <div id="polyharmonic-graph" class="graph"></div>
    <div id="fourie-freq" class="graph"></div>
    <div id="fourie-phase" class="graph"></div>
    <div id="fourie-akf" class="graph"></div>
    <div id="fourie-inverse" class="graph"></div>
</div>

</div>
</body>
</html>
