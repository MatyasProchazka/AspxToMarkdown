# Power BI report templates
     
For basic information about Power BI report templates, please refer to the [Power BI report templates](../../alvao-asset-management/searching/power-bi) chapter of the ALVAO Asset Management product.
      
## Alvao Analysis
      
The assembly contains the following pages:
     
- **Historical overview**- an overview of key trends over time
    - **Number of open requests** - in this chart you can see how the number of open requests is trending over time. The graph should be stagnant or, better yet, decreasing. If the graph is increasing, the resolution team is probably not keeping up with the incoming requests.
  In the report filters, choose the [services](../../alvao-service-desk/implementation/services/service-roles) for which you want to display the graph, and change the period displayed if necessary.
    - **Number of requests** - In this chart you can see the evolution of the number of newly created, closed and deleted requests over time, i.e. a more detailed view of the gains and losses in the number of open requests from the top chart. By viewing the graph for a longer period of time, you can see, for example, regularly recurring seasonal peaks in service load and compare the magnitude of these fluctuations between years.
    - **Team work (hours)** - you can see in the graph how much time individual workers have spent on a given request (see [Time Reporting](../../alvao-service-desk/requests/work-time)). Thus, you can discover that, for example, the increase in the number of open requests in the top graph is not due to a currently higher demand for the service (second graph), but because the solution team is not currently paying enough attention to the requests (third graph).

> [!TIP]
> You can analyze the details in the charts on this and some other pages, see [Mode to go to details in the Power BI visual](https://docs.microsoft.com/en-us/power-bi/consumer/end-user-drill). For example, time charts that default to displaying data by weeks can be switched to display by months or days. Similarly, you can switch user maps to organization maps or service maps to root service or request maps.

- **First response fulfillment**- analysis of time to first response
    - **Average time to response** - the chart shows the evolution of the average time to first response over time for each SLA.
    - **First Response** - in the bar chart you can see the number of requests in which the first response was fulfilled (green) or not fulfilled (red). The line graph shows the average success rate of first responses in percentage. Select a value with the mouse and the table below the graph shows details of the relevant requests. The link in the last column of the table leads directly to the web page of the request.
- **Resolution fulfillment** - time to resolution analysis. The page has a similar structure to the *First response fulfillment* page.
- **Last week** - at the top of the page you can see tabs with the values of selected KPIs for the past week and their comparison with the previous week and the same week last year.   Hover your mouse over the current value and a bubble will show a detailed chart of the evolution of that KPI over the year.   In the bottom graphs, you can see the first response success rate and time to resolution by solver, and the work of the people who put time into [requests](../../alvao-service-desk/requests/work-time).
- **Satisfaction survey** - on this page you will find an evaluation of the submitted [satisfaction surveys](../../modules/alvao-satisfaction-feedback). The tabs at the top of the page represent each question of the survey.   Each tab shows the average of the responses as a value ranging from 1 to 4 (1=unsatisfied, 4=satisfied), the frequency of each response, and a graph of the evolution of the average response over time. Click on any value and the bottom table will show the verbal comments made by the applicants in the respective requests.   Satisfaction questionnaires are part of the [ALVAO Satisfaction Feedback](../../modules/alvao-satisfaction-feedback) module.
- **New requests**- analysis of the creation of new requests
    - **Request submission methods** - you can see the ratio between the different request submission methods in the graph.
    - **Number of submitted requests** - a graph of the evolution of the number of requests created over time by each submission method.
    - **Service load** - in the table you can see the number of requests created in each service.
    - **New requests by service** - graph of the evolution of the number of requests created over time by service.

> [!TIP]
> Right-click on any value in the charts, select **Drill through - Request table** from the menu, and the corresponding request table will appear on the page. To return to the report page, click the arrow in the upper left corner. 

- **Daily utilization** - track the number of requests created and resolved during the day.   In the top chart you can see the number of requests created at each hour of the day and in the bottom chart the number of requests resolved. Click on any value in the graphs and the corresponding requests will be displayed in the bottom table.   The hours displayed are in the UTC time zone.
- **Request analysis** - The graphs show the number of requests sequentially by Requester, solver, service, status, and SLA. Use the *Overall status* filter to view only open or closed requests.
- **Work (hours)** - The top two maps show the number of [hours posted to requests](../../alvao-service-desk/requests/work-time) by service (left) and user (right), respectively. In the bottom chart, you can see the progression of reported hours over time. If you only want to view the graph for a service or user, click on the service or user in the maps above the graph.   In the table below the graph, the corresponding requests are displayed at the same time.
- [The remaining pages of the report](../../alvao-asset-management/searching/power-bi) relate (also) to the ALVAO Asset Management product.
