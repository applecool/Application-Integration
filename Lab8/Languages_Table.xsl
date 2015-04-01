<?xml version="1.0"?>
<xsl:transform xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:attribute-set name="spacious-table">
    <xsl:attribute name="width">100%</xsl:attribute>
    <xsl:attribute name="text-align">left</xsl:attribute>
    <xsl:attribute name="padding">15px</xsl:attribute>
    <xsl:attribute name="border">1px solid black</xsl:attribute>
  </xsl:attribute-set>
  <xsl:param name="elementPath" select="languages/language[intendeduses/intendeduse/@id='_3']" />
  <xsl:template match="/">
    <html>
      <body>
        <style>
					table, th, td {
					border: 1px solid black;
					border-collapse: collapse;
					}
					table{
					cellpadding: 10px ;
					}
				</style>
        <table xsl:use-attribute-sets="spacious-table" style="border-collapse:collapse">
          <tr>
            <th>Language</th>
            <th>Intended Use</th>
            <th>Imperative </th>
            <th>Object-Oriented</th>
            <th>Functional </th>
            <th>Procedural</th>
            <th>Generic</th>
            <th>Reflective </th>
            <th>Event-Driven</th>
            <th>Standard</th>
          </tr>
          <xsl:for-each select="$elementPath">
            <tr>
              <td>
                <xsl:value-of select="name" />
              </td>
              <td width="125px">
                <xsl:for-each select="intendeduses/intendeduse">
                  <xsl:variable name="particularuse" select="@id" />
                  <xsl:for-each select="//uses">
                    <xsl:value-of select="use[@uid=$particularuse]" />
                    <br>
                    </br>
                  </xsl:for-each>
                </xsl:for-each>
              </td>
              <td>
                <xsl:value-of select="imperative" />
              </td>
              <td>
                <xsl:value-of select="object-oriented" />
              </td>
              <td>
                <xsl:value-of select="functional" />
              </td>
              <td>
                <xsl:value-of select="procedural" />
              </td>
              <td>
                <xsl:value-of select="generic" />
              </td>
              <td>
                <xsl:value-of select="reflective" />
              </td>
              <td>
                <xsl:value-of select="event-driven" />
              </td>
              <td>
                <xsl:for-each select="standardtypes/standardtype">
                  <xsl:variable name="particularstandard" select="@id" />
                  <xsl:for-each select="//standards">
                    <xsl:value-of select="type[@tid=$particularstandard]" />
                    <br>
                    </br>
                  </xsl:for-each>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:transform>