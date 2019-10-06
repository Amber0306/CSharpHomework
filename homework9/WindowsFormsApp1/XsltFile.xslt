<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="ArrayOfOrder">
	   <html>
      <head><title>Order List</title></head>
      <body>
        <table border="1">
          <tr  bgcolor="#fc9ce7">
            <th>订单号</th>
            <th>客户名称</th>
			<th>客户电话号码</th>
			<th>订单总额</th>
          </tr>
		  <xsl:for-each select="Order">
            <tr>
              <td>
                <xsl:value-of select="id"/>
              </td>
              <td>
                <xsl:value-of select="customer"/>
              </td>
			  <td>
                <xsl:value-of select="phone"/>
              </td>
			  <td>
                <xsl:value-of select="sum"/>
              </td>
            </tr>
          </xsl:for-each>
		 </table>
		 
		<xsl:for-each select="Order"> 
            <h>Order<xsl:value-of select="id"/></h>
			
			<table border="1">
			   <tr  bgcolor="#fc9ce7">
               <th>商品名称</th>
               <th>购买数量</th>
               <th>商品单价</th>
               </tr>
			  <xsl:for-each select="orderdata">
                <xsl:for-each select="OrderDetail">
                <tr>
                    <td>
                      <xsl:value-of select="pdtName"/>
                    </td>
                    <td>
                      <xsl:value-of select="pdtPrice"/>
                    </td>                    
                    <td>
                      <xsl:value-of select="pdtNumber"/>
                    </td>
                </tr>
                </xsl:for-each>
              </xsl:for-each>
			</table>
			
			
		</xsl:for-each>
		
	  </body>
    </html>
  </xsl:template>
</xsl:stylesheet>