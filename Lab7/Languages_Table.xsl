<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:attribute-set name="spacious-table">
		<xsl:attribute name="width">100%</xsl:attribute>
		<xsl:attribute name="text-align">left</xsl:attribute>
		<xsl:attribute name="padding">15px</xsl:attribute>
		<xsl:attribute name="border">1px solid black</xsl:attribute>
	</xsl:attribute-set>
	<xsl:key name="use_id" match="use" use="@id"/>
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
					<xsl:for-each select="languages/language">
						<tr>
							<td>
								<xsl:value-of select="name"/>
							</td>
							<td width="125px">													
								<xsl:for-each select="intendeduses/intendeduse">									
									<xsl:variable name="particularuse" select="@id" />
									<xsl:for-each select="//uses">
									<xsl:variable name="useid" select="use/@uid" />									
									<xsl:choose>
										<xsl:when test="$particularuse=$useid">
											<br>
												<xsl:value-of select="use[@uid=$particularuse]"/>
											</br>										
										</xsl:when>
										<xsl:otherwise>										
										</xsl:otherwise>
									</xsl:choose>
									</xsl:for-each>
								</xsl:for-each>
							</td>
							<td>
								<xsl:value-of select="imperative"/>
							</td>
							<td>
								<xsl:value-of select="object-oriented"/>
							</td>
							<td>
								<xsl:value-of select="functional"/>
							</td>
							<td>
								<xsl:value-of select="procedural"/>
							</td>
							<td>
								<xsl:value-of select="generic"/>
							</td>
							<td>
								<xsl:value-of select="reflective"/>
							</td>
							<td>
								<xsl:value-of select="event-driven"/>
							</td>
							<td>
								<xsl:for-each select="standardtypes/standardtype">
									<xsl:variable name="particularstandard" select="@id" />
									<xsl:for-each select="//standards">
										<xsl:variable name="standardid" select="type/@tid" />
										<xsl:choose>
											<xsl:when test="$particularstandard=$standardid">
												<xsl:value-of select="type[@tid=$particularstandard]"/>
												<br></br>
											</xsl:when>
											<xsl:otherwise>
											</xsl:otherwise>
										</xsl:choose>
									</xsl:for-each>
								</xsl:for-each>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>