#-*- coding: UTF-8 -*- 
from urllib import parse
from urllib import request
from bs4 import BeautifulSoup
import pymysql
import time

def pachong():
    url = "https://srh.bankofchina.com/search/whpj/search_cn.jsp"
    for money in ['美元','欧元','日元','英镑']:
        Form_Data = {}
        Form_Data['erectDate'] = ''
        Form_Data['nothing'] = ''
        Form_Data['pjname'] = money
        data = parse.urlencode(Form_Data).encode('utf-8')
        html = request.urlopen(url,data).read()
        soup = BeautifulSoup(html,'html.parser')
        div = soup.find('div', attrs = {'class':'BOC_main publish'})
        table = div.find('table')
        tr = table.find_all('tr')
        td = tr[1].find_all('td')
        a = td[0].get_text()
        b = td[6].get_text()
        c = td[3].get_text()
        print(a,b,c)
        db = pymysql.connect(host="localhost",user="root", passwd="Winson2000_", db="bank")
        cursor = db.cursor()
        cursor.execute('insert into pro values("%s", "%s","%s")' % \
             (td[0].get_text(), td[6].get_text(), td[3].get_text()))
        db.commit()
        db.close()
        print("数据爬取完成")

def update():
    url = "https://srh.bankofchina.com/search/whpj/search_cn.jsp"
    for money in ['美元','欧元','日元','英镑']:
        Form_Data = {}
        Form_Data['erectDate'] = ''
        Form_Data['nothing'] = ''
        Form_Data['pjname'] = money
        data = parse.urlencode(Form_Data).encode('utf-8')
        html = request.urlopen(url,data).read()
        soup = BeautifulSoup(html,'html.parser')
        div = soup.find('div', attrs = {'class':'BOC_main publish'})
        table = div.find('table')
        tr = table.find_all('tr')
        td = tr[1].find_all('td')
        a = td[0].get_text()
        b = td[6].get_text()
        c = td[3].get_text()
        print(a,b,c)
        db = pymysql.connect(host="localhost",user="root", passwd="Winson2000_", db="bank")
        cursor = db.cursor()
        cursor.execute('UPDATE pro SET tim = "%s",val = "%s" WHERE money = "%s"' % \
             (td[6].get_text(), td[3].get_text(), td[0].get_text()))
        db.commit()
        db.close()
        print("数据修改完成")

pachong()
while True:
    update()
#    print("请等待10秒")
    time.sleep(7200)

