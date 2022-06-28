FROM nginx:alpine
 # use a volume is mor efficient and speed that filesystem
VOLUME /tmp
RUN rm -rf /usr/share/nginx/html/*
COPY nginx.conf /etc/nginx/nginx.conf
COPY zmejApp_prep /usr/share/nginx/html/zmejApp_prep
COPY zmejApp_prod /usr/share/nginx/html/zmejApp_prod
#expose app and 80 for nginx app
EXPOSE 80 81
CMD ["nginx", "-g", "daemon off;"]

