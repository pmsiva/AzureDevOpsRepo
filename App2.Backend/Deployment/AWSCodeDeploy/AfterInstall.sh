#!/bin/bash

sudo systemctl daemon-reload
sudo systemctl enable kestrel-App2.service
sudo systemctl start kestrel-App2.service