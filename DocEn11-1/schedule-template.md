# Schedule
      
Use this form to schedule the automatic periodic creation of new requests according to a selected [request template](../../../alvao-service-desk/requests/ticket-templates).

> [!TIP]
> 

Automatically created requests are linked by a *precedes before - follows after* type link. Each time you change the scheduling, the chain of links is broken.

> [!TIP]
> 

Options:
   
- **Automatically create requests based on this template** - enable if you want to automatically create requests according to the selected request template. Disabling this option will temporarily disable the set request creation.
- **Requester** - enter at least part of the name of the requester for whom the requests are to be automatically created, and then select the requester from the menu.
- **Repeat**- select the frequency of request creation and specify additional time parameters.
TODO T129697ALVAO    - **Daily**
        - **Repetion period (days)** - enter the duration of the repeating in days.
        - **On weekdays** - choose if you want to repeat the request every weekday.
        - **Create a new request after resolution of the previous one in the sequence in (days)** - enter the number of days for automatic creation of new requests.
    - **Weekly**
        - **Repetion period (weeks)**
            - **Repetition period** - enter duration of the repeating in weeks.
            - **In these days** - check the days you want the repetition to occur.
        - **Create a new request after resolution of the previous one in the sequence in (weeks)** - enter the number of weeks for automatic creation of new requests.
    - **Monthly**
        - **Day of month** - choose the day of repetiton by its date
            - **Day** - enter the day of month when will the repetition occur.
            - **Repetion period (months)** - enter duration of the repetition in months
        - **Weekday** - choose the day by its position in month.
            - **Weekday** - choose the week of month for the repetition
            - **Day of the week** - choose the day
            - **Repetion period (months)** - enter duration of the repetition in months
        - **Create a new request after resolution of the previous one in the sequence in (months)** - enter the number of months for automatic creation of new requests.
    - **Yearly**
        - **Day of month** - choose if you want to specify a single day for the repetition to occur by its date.
            - **Day** - enter the day of the repetition
            - **Month** - select the month
        - **Weekday** - you can specify the day of the repetition by its position in year.
            - **Week of the month** - choose the week
            - **Day** - select the day of the week
            - **Month** - select the month
    - **Create a new request after resolution of the previous one in the sequence in (years)** - enter the number of years for automatic creation of new requests.
- **Extent of repetition**
    - **Start** - enter the day on which the first request is due.
    - **End**- select how long requests are to be created:
        - **Indefinitely**
        - **End after (occurrences)** - enter the total number of requests you want to create.
        - **End** - enter the day on which to create the last request.
